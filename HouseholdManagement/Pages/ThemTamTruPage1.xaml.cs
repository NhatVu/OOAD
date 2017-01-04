using DataAcessLayer;
using DTO;
using HouseholdManagement.Utilities;
using HouseholdManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace HouseholdManagement.Pages
{
    /// <summary>
    /// Interaction logic for ThemHoKhauPage1.xaml
    /// </summary>
    public partial class ThemTamTruPage1 : Page
    {
        private CongAnDTO mCongan;
        private ThemTamTruPage1ViewModel mViewModel;
        private int mType;//Them tam vang hay them tam tru

        public static ThemTamTruPage1 createInstance(int type, CongAnDTO congan)
        {
            return new ThemTamTruPage1(type, congan);
        }


        public ThemTamTruPage1(int type, CongAnDTO congan)
        {

            InitializeComponent();
            this.mCongan = congan;
            this.mType = type;

        }

        private void onButtonNextClicked(object sender, RoutedEventArgs e)
        {


            if (textbox_diachi.Text.Trim().ToString().Count() == 0)
            {
                Constant.showDialog("Xin vui lòng nhập địa chỉ");
                return;
            }


            if (textbox_lydo.Text.Trim().ToString().Count() == 0)
            {
                Constant.showDialog("Xin vui lòng nhập lý do");
                return;
            }



            if (datepicker_ngaybatdau.SelectedDate == null || datepicker_ngayketthuc.SelectedDate == null)
            {
                Constant.showDialog("Xin vui lòng nhập ngày bắt đầu và ngày kết thúc");
                return;
            }

            DateTime ngaybatdau = DateTime.Parse(datepicker_ngaybatdau.SelectedDate.ToString());
            DateTime ngayketthuc = DateTime.Parse(datepicker_ngayketthuc.SelectedDate.ToString());
            DateTime ngayLamDon = DateTime.Parse(datepicker_ngaylamdon.SelectedDate.ToString());

            if (ngayketthuc.Date < ngaybatdau.Date)
            {
                Constant.showDialog("Xin vui lòng nhập ngày kết thúc lớn hơn ngày bắt đầu");
                return;
            }

            if(txt_id.Text.Trim().ToString().Count() == 0)
            {
                Constant.showDialog("Xin vui lòng chọn một công dân");
                return;
            }

            int idCongAn = mCongan.Id;
            string lydo = textbox_lydo.Text.Trim();
            string diachi = textbox_diachi.Text.Trim();
            string ghichu = textbox_ghichu.Text.Trim();


            this.NavigationService.Navigate(ThemTamTruPage2.createInstance(mType, idCongAn, lydo, diachi, ghichu, ngaybatdau, ngayketthuc, ngayLamDon,int.Parse(txt_id.Text)));
        }

        private void onButtonCancelClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(QuanlyTamTru.createInstance());
        }

        private async void onLoaded(object sender, RoutedEventArgs e)
        {
            

            progressbar.Visibility = System.Windows.Visibility.Visible;
            await Task.Delay(1000);
            mViewModel = new ThemTamTruPage1ViewModel(mCongan);
            DataContext = mViewModel;
            datepicker_ngaylamdon.SelectedDate = mViewModel.NgayLamDon;
            datepicker_ngaybatdau.BlackoutDates.AddDatesInPast();
            datepicker_ngayketthuc.BlackoutDates.AddDatesInPast();
            progressbar.Visibility = System.Windows.Visibility.Hidden;


        }

        private void combobox_idCongdan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = sender as ComboBox;
            if (box.SelectedValue != null && box.SelectedValue.ToString().Count() > 0)
            {
                try
                {
                    string value = (box.SelectedValue + "");
                    CongDanDTO congdan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectCongDanById(int.Parse(value)))[0];
                    if (congdan != null)
                        updateData(congdan);
                }
                catch (Exception ex)
                {
                    Constant.showDialog("Tên bạn nhập không tồn tại");
                }
            }
        }


        private void combobox_cmndCongdan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = sender as ComboBox;
            if (box.SelectedValue != null && box.SelectedValue.ToString().Count() > 0)
            {
                try
                {
                    int value = int.Parse(box.SelectedValue + "");
                    CongDanDTO congdan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectCongDanByCmnd(value))[0];
                    if (congdan != null)
                        updateData(congdan);
                }
                catch (Exception ex)
                {
                    Constant.showDialog("Cmnd bạn nhập không tồn tại");
                }
            }
        }

        private void combobox_tenCongdan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = sender as ComboBox;
            if (box.SelectedValue != null && box.SelectedValue.ToString().Count() > 0)
            {
                try
                {
                    string value = (box.SelectedValue + "");
                    CongDanDTO congdan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectCongDanByName(value))[0];
                    if (congdan != null)
                        updateData(congdan);
                }
                catch (Exception ex)
                {
                    Constant.showDialog("Cmnd bạn nhập không tồn tại");
                }
            }
        }

        private void updateData(CongDanDTO congdan)
        {
            if (congdan != null)
            {
                panel_thongtin.Visibility = Visibility.Visible;
                txt_id.Text = congdan.Id + "";
                txt_gioitinh.Text = congdan.GioiTinh == 1 ? "Nam" : "Nữ";
                txt_hoten.Text = congdan.HoTen;
                txt_ngaysinh.Text = congdan.NgaySinh.ToString("dd/MM/yyyy");
                txt_cmnd.Text = (congdan.Cmnd != 0) ? (congdan.Cmnd + "") : "Chưa có";
                txt_quequan.Text = congdan.Quequan;

                try
                {
                    TienAnDTO tienan = Constant.DataTableToList<TienAnDTO>(new TienAnDAO().SelectTienAnByCongDanId(congdan.Id))[0];

                    if (tienan != null)
                    {
                        panel_tienan.Visibility = Visibility.Visible;
                        txt_toidanh.Text = tienan.Toidanh;
                        txt_hinhphat.Text = tienan.Hinhphat;
                        txt_noituyenan.Text = tienan.NoiTuyenAn;
                        txt_thoigian.Text = tienan.NgayThang.ToString("dd/MM/yyyy"); ;
                    }
                }
                catch
                {
                    panel_tienan.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                panel_thongtin.Visibility = Visibility.Collapsed;
            }
        }

        private void combobox_idCongdan_KeyDown(object sender, KeyEventArgs e)
        {
            ComboBox box = sender as ComboBox;
            if (e.Key == Key.Enter)
            {
                try
                {
                    int value = int.Parse(box.Text);
                    CongDanDTO congdan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectCongDanById(value))[0];
                }
                catch (Exception ex)
                {
                    Constant.showDialog("Dữ liệu nhập vào không tồn tại");
                }

            }
        }

        private void combobox_cmndCongdan_KeyDown(object sender, KeyEventArgs e)
        {
            ComboBox box = sender as ComboBox;
            if (e.Key == Key.Enter)
            {
                try
                {
                    int value = int.Parse(box.Text);
                    CongDanDTO congdan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectCongDanByCmnd(value))[0];
                }
                catch (Exception ex)
                {
                    Constant.showDialog("Dữ liệu nhập vào không tồn tại");
                }

            }
        }



        private void combobox_tenCongdan_KeyDown(object sender, KeyEventArgs e)
        {
            ComboBox box = sender as ComboBox;
            if (e.Key == Key.Enter)
            {
                try
                {
                    string value = (box.Text);
                    CongDanDTO congdan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectCongDanByName(value))[0];
                }
                catch (Exception ex)
                {
                    Constant.showDialog("Dữ liệu nhập vào không tồn tại");
                }

            }
        }
    }
}

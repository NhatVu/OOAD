using DataAcessLayer;
using DTO;
using HouseholdManagement.UserControls;
using HouseholdManagement.Utilities;
using HouseholdManagement.ViewModels;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
    /// Interaction logic for ThemHoKhauPage2.xaml
    /// </summary>
    public partial class ChuyenKhauPage1 : Page
    {
        private ChuyenKhauPage1ViewModel mViewModel;

        public static ChuyenKhauPage1 createInstance()
        {
            return new ChuyenKhauPage1();
        }
        public ChuyenKhauPage1()
        {
            InitializeComponent();
        }

        private void onButtonBackClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void onButtonNextClicked(object sender, RoutedEventArgs e)
        {
            if (textbox_lydo.Text.Trim().Count() == 0)
            {
                Constant.showDialog("Bạn phải điền lý do");
                return;
            }

            int sum = 0;
        
            foreach(SelectCongDanViewModel view in mViewModel.ListCongDan)
            {
                if (view.IsSelected == true)
                    sum++;
            }
            if(sum == 0)
            {
                Constant.showDialog("Bạn phải chọn ít nhất một người để chuyển sang hộ khẩu mới");
                return;
            }

            this.NavigationService.Navigate(ChuyenKhauPage2.createInstance(mViewModel.ListCongDan,
                int.Parse(combobox_idHoKhau.SelectedValue+""),
                textbox_lydo.Text.ToString().Trim(),
                textbox_ghichu.Text.ToString().Trim()));



        }

        private async void onLoaded(object sender, RoutedEventArgs e)
        {
            progressbar.Visibility = System.Windows.Visibility.Visible;
            await Task.Delay(1000);
            mViewModel = new ChuyenKhauPage1ViewModel();
            DataContext = mViewModel;
            progressbar.Visibility = System.Windows.Visibility.Hidden;
        }

        private void idHoKhau_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = sender as ComboBox;
            int row = table_household.SelectedIndex;
            if (true)
            {
                try
                {

                    int value = int.Parse(box.SelectedValue + "");
                    List<ChiTietHoKhauDTO> chitiet = Constant.DataTableToList<ChiTietHoKhauDTO>(new ChiTietHoKhauDAO().SelectAllChiTietHoKhauByIdHoKhau(value));

                    if (chitiet != null)
                    {
                        if (mViewModel.ListCongDan.Count > 0)
                            mViewModel.ListCongDan = new ObservableCollection<SelectCongDanViewModel>();
                        mViewModel.IsAllItemSelected = false;
                    
                        for (int i = 0; i < chitiet.Count; i++)
                        {
                            ChiTietHoKhauDTO ct = chitiet[i];
                            if (ct.IdVaiTroSoHoKhau != 1)
                            {
                                string quanhe = mViewModel.ListQuanhe.FirstOrDefault(x => x.Id == ct.IdVaiTroSoHoKhau).TenVaitro;

                                CongDanDTO congdan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectCongDanById(ct.IdCDThanhVien))[0];
                                string id = congdan.Id + "";
                                string cmnd = (congdan.Cmnd != 0) ? (congdan.Cmnd + "") : "Chưa có";
                                string hoten = congdan.HoTen;
                                string ngaysinh = congdan.NgaySinh.ToString("dd/MM/yyyy");
                                string gioitinh = (congdan.GioiTinh == 0) ? "Nữ" : "Nam";
                                string quequan = congdan.Quequan;


                                mViewModel.ListCongDan.Add(new SelectCongDanViewModel());
                                int max = mViewModel.ListCongDan.Count - 1;
                                mViewModel.ListCongDan[max].Id = id;
                                mViewModel.ListCongDan[max].Cmnd = cmnd;
                                mViewModel.ListCongDan[max].Gioitinh = gioitinh;
                                mViewModel.ListCongDan[max].Name = hoten;
                                mViewModel.ListCongDan[max].Ngaysinh = ngaysinh;
                                mViewModel.ListCongDan[max].Quanhe = quanhe;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Constant.showDialog("Bạn đã nhập số hộ khẩu sai");
                }
            }
        }


        private void updateTableRow(List<ChiTietHoKhauDTO> chitiet, int row)
        {





        }

        private void idHoKhau_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}

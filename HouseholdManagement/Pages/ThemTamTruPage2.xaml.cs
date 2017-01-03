using DataAcessLayer;
using DTO;
using HouseholdManagement.UserControls;
using HouseholdManagement.Utilities;
using HouseholdManagement.ViewModels;
using MaterialDesignThemes.Wpf;
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
    /// Interaction logic for ThemHoKhauPage2.xaml
    /// </summary>
    public partial class ThemTamTruPage2 : Page
    {
        private int mType;
        private int mIdCongAn;
        private string mLydo;
        private string mDiachi;
        private string mGhichu;
        private DateTime mNgayBatdau;
        private DateTime mNgayKetthuc;
        private DateTime mNgayLamDon;

        private ThemTamTruPage2ViewModel mViewModel;

        public static ThemTamTruPage2 createInstance(int type, int idCongAn, string lydo, string diachi, string ghichu, DateTime ngaybatdau, DateTime ngayketthuc, DateTime ngayLamDon)
        {
            return new ThemTamTruPage2(type, idCongAn,lydo,diachi,ghichu,ngaybatdau,ngayketthuc, ngayLamDon);
        }
        public ThemTamTruPage2(int type, int idCongAn, string lydo, string diachi, string ghichu, DateTime ngaybatdau, DateTime ngayketthuc, DateTime ngayLamDon)
        {
            InitializeComponent();
            this.mType = type;
            this.mIdCongAn = idCongAn;
            this.mLydo = lydo;
            this.mDiachi = diachi;
            this.mGhichu = ghichu;
            this.mNgayBatdau = ngaybatdau;
            this.mNgayKetthuc = ngayketthuc;
            this.mNgayLamDon = ngayLamDon;
        }

        private void onButtonBackClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private async void onButtonSaveClicked(object sender, RoutedEventArgs e)
        {    
            if(mType == Constant.TYPE_THEM_TAM_TRU)
            {
                //save tam tru
                TamTruDAO tamTruDAO = new TamTruDAO();
                TamTruDTO dto = new TamTruDTO();
                foreach (SelectTamTruViewlModel current in mViewModel.ListTamTru)
                {
                    dto.Active = 1;
                    dto.IdCongdan = UserConvert.convertInt(current.Id);
                    dto.DiachiDen = this.mDiachi;
                    dto.Ghichu = "";
                    dto.IdTruongCongan = GlobalVariable.CurrentCongAnId;
                    dto.Lydo = this.mLydo;
                    dto.NgayBatdau = this.mNgayBatdau;
                    dto.NgayKetthuc = this.mNgayKetthuc;
                    dto.NgayLamDon = this.mNgayLamDon;


                    tamTruDAO.insertTamTru(dto);
                }
                //save tam vang
                Constant.showDialog("Thêm tạm trú thành công");
                this.NavigationService.Navigate(QuanlyTamTru.createInstance());
            }else if(mType == Constant.TYPE_THEM_TAM_VANG)
            {
                TamVangDAO tamVangDAO = new TamVangDAO();
                TamVangDTO dto = new TamVangDTO();
                foreach (SelectTamTruViewlModel current in mViewModel.ListTamTru)
                {
                    dto.Active = 1;
                    dto.IdCongdan = UserConvert.convertInt(current.Id);
                    dto.DiaChiDen = this.mDiachi;
                    dto.GhiChu = "";
                    dto.IdTruongCongAn = GlobalVariable.CurrentCongAnId;
                    dto.LyDo = this.mLydo;
                    dto.NgayBatDau = this.mNgayBatdau;
                    dto.NgayKetThuc = this.mNgayKetthuc;
                    dto.NgayLamDon = this.mNgayLamDon;


                    tamVangDAO.insertTamVang(dto);
                }
                //save tam vang
                Constant.showDialog("Thêm tạm vắng thành công");
                this.NavigationService.Navigate(QuanlyTamVang.createInstance());
            }

            //List<string> ids = new List<string>();
            //ids.Clear();
            //foreach (SelectTamTruViewlModel row in mViewModel.ListTamTru)
            //{
            //    //MessageBox.Show(row.Id + row.Cmnd + row.Name + row.Quanhe + row.GhiChu);
            //    ids.Add(row.Id);

            //}
            //bool isUnique = ids.Distinct().Count() == ids.Count();

            //if (isUnique)
            //{
            //    progressbar.Visibility = System.Windows.Visibility.Visible;
            //    await Task.Delay(500);
            //    await Task.Run(() => insertToDataBase());
            //    progressbar.Visibility = System.Windows.Visibility.Hidden;

            //    //

            //    this.NavigationService.Navigate(QuanlyHokhau.createInstance());
            //}
            //else
            //{
            //    Constant.showDialog("Tất cả các thành viên phải khác nhau");
            //}

        }

        private void insertToDataBase()
        {
            //try
            //{
            //    int idHoKhau = new HoKhauDAO().insertHoKhau(mHoKhau);
            //    List<VaiTroSoHoKhauDTO> vaitro = Constant.DataTableToList<VaiTroSoHoKhauDTO>(new VaiTroSoHoKhauDAO().SelectAllVaiTroSoHoKhau());
            //    int idHoKhau = mHoKhau.Id;
            //    foreach (SelectTamTruViewlModel row in mViewModel.ListTamTru)
            //    {
            //        ChiTietHoKhauDTO chitietHoKhau = new ChiTietHoKhauDTO(idHoKhau,
            //            int.Parse(row.Id),
            //            vaitro.Find(x => x.TenVaitro == row.Quanhe).Id,
            //            row.GhiChu,
            //            1);
            //        new ChiTietHoKhauDAO().insertChiTietHoKhau(chitietHoKhau);
            //    }
            //}
            //finally
            //{
            //    MessageBox.Show("Thêm hộ khẩu thành công");
            //}
        }

        private void table_household_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void onButtonAddClicked(object sender, RoutedEventArgs e)
        {
            if (mViewModel != null)
                mViewModel.ListTamTru.Add(new SelectTamTruViewlModel());
        }

        private void onButtonRemoveClicked(object sender, RoutedEventArgs e)
        {
            if (table_household.SelectedIndex > -1)
            {
                for (int i = table_household.SelectedItems.Count - 1; i >= 0; i--)
                {
                    mViewModel.ListTamTru.RemoveAt(i);
                }
            }
        }

        private void onButtonResetClicked(object sender, RoutedEventArgs e)
        {
            if (mViewModel != null && mViewModel.ListTamTru.Count > 0)
            {
                for (int i = mViewModel.ListTamTru.Count - 1; i >= 0; i--)
                {
                    mViewModel.ListTamTru.RemoveAt(i);
                }
                mViewModel.ListTamTru.Add(new SelectTamTruViewlModel());
            }
        }

        private async void onLoaded(object sender, RoutedEventArgs e)
        {
            progressbar.Visibility = System.Windows.Visibility.Visible;
            await Task.Delay(1000);
            mViewModel = new ThemTamTruPage2ViewModel();
            DataContext = mViewModel;
            progressbar.Visibility = System.Windows.Visibility.Hidden;
        }

        private void id_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = sender as ComboBox;
            int row = table_household.SelectedIndex;
            if (true)
            {
                try
                {

                    int value = int.Parse(box.SelectedValue + "");
                    CongDanDTO congdan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectCongDanById(value))[0];
                    if (congdan != null)
                        updateTableRow(congdan, row);
                }
                catch (Exception ex)
                {
                    Constant.showDialog("Id bạn nhập không tồn tại");
                }
            }
        }

        private void cmnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = sender as ComboBox;
            int row = table_household.SelectedIndex;
            if (box.SelectedValue != null && box.SelectedValue.ToString().Count() > 0)
            {
                try
                {
                    int value = int.Parse(box.SelectedValue + "");
                    CongDanDTO congdan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectCongDanByCmnd(value))[0];
                    int id = congdan.Id;
                    mViewModel.ListTamTru[row].Id = id + "";
                }
                catch (Exception ex)
                {
                    Constant.showDialog("Cmnd bạn nhập không tồn tại");
                }
            }

        }

        private void ten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = sender as ComboBox;
            int row = table_household.SelectedIndex;
            if (box.SelectedValue != null && box.SelectedValue.ToString().Count() > 0)
            {
                try
                {
                    string value = (box.SelectedValue + "");
                    CongDanDTO congdan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectCongDanByName(value))[0];
                    int id = congdan.Id;
                    mViewModel.ListTamTru[row].Id = id + "";
                }
                catch (Exception ex)
                {
                    Constant.showDialog("Tên bạn nhập không tồn tại");
                }
            }
        }

        private void updateTableRow(CongDanDTO congdan, int row)
        {
            string cmnd = (congdan.Cmnd != 0) ? (congdan.Cmnd + "") : "Chưa có";
            string hoten = congdan.HoTen;
            string ngaysinh = congdan.NgaySinh.ToString("dd/MM/yyyy");
            string gioitinh = (congdan.GioiTinh == 0) ? "Nữ" : "Nam";
            string quequan = congdan.Quequan;

            mViewModel.ListTamTru[row].Cmnd = cmnd;
            mViewModel.ListTamTru[row].Gioitinh = gioitinh;
            mViewModel.ListTamTru[row].Name = hoten;
            mViewModel.ListTamTru[row].Ngaysinh = ngaysinh;
            mViewModel.ListTamTru[row].QueQuan = quequan;
        }



        private void id_KeyDown(object sender, KeyEventArgs e)
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
                    mViewModel.ListTamTru[table_household.SelectedIndex] = new SelectTamTruViewlModel();
                }

            }
        }

        private void cmnd_KeyDown(object sender, KeyEventArgs e)
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
                    mViewModel.ListTamTru[table_household.SelectedIndex] = new SelectTamTruViewlModel();
                }

            }
        }

        private void ten_KeyDown(object sender, KeyEventArgs e)
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
                    mViewModel.ListTamTru[table_household.SelectedIndex] = new SelectTamTruViewlModel();
                }

            }
        }
    }
}

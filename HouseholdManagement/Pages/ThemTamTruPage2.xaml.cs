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
using HouseholdManagement.Utilities;

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
        private int mIdCongDan;

        private ThemTamTruPage2ViewModel mViewModel;

        public static ThemTamTruPage2 createInstance(int type, int idCongAn, string lydo, string diachi, string ghichu, DateTime ngaybatdau, DateTime ngayketthuc, DateTime ngayLamDon, int idCongdan)
        {
            return new ThemTamTruPage2(type, idCongAn, lydo, diachi, ghichu, ngaybatdau, ngayketthuc, ngayLamDon, idCongdan);
        }
        public ThemTamTruPage2(int type, int idCongAn, string lydo, string diachi, string ghichu, DateTime ngaybatdau, DateTime ngayketthuc, DateTime ngayLamDon, int idCongdan)
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
            this.mIdCongDan = idCongdan;
        }

        private void onButtonBackClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private async void onButtonSaveClicked(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            //if(mType == Constant.TYPE_THEM_TAM_TRU)
            //{
            //    //save tam tru
            //    TamTruDAO tamTruDAO = new TamTruDAO();
            //    TamTruDTO dto = new TamTruDTO();
            //    foreach (SelectTamTruViewlModel current in mViewModel.ListTamTru)
            //    {
            //        dto.Active = 1;
            //        dto.IdCongdan = UserConvert.convertInt(current.Id);
            //        dto.DiachiDen = this.mDiachi;
            //        dto.Ghichu = "";
            //        dto.IdTruongCongan = GlobalVariable.CurrentCongAnId;
            //        dto.Lydo = this.mLydo;
            //        dto.NgayBatdau = this.mNgayBatdau;
            //        dto.NgayKetthuc = this.mNgayKetthuc;
            //        dto.NgayLamDon = this.mNgayLamDon;


            //        tamTruDAO.insertTamTru(dto);
            //    }
            //    //save tam vang
            //    Constant.showDialog("Thêm tạm trú thành công");
            //    this.NavigationService.Navigate(QuanlyTamTru.createInstance());
            //}else if(mType == Constant.TYPE_THEM_TAM_VANG)
            //{
            //    TamVangDAO tamVangDAO = new TamVangDAO();
            //    TamVangDTO dto = new TamVangDTO();
            //    foreach (SelectTamTruViewlModel current in mViewModel.ListTamTru)
            //    {
            //        dto.Active = 1;
            //        dto.IdCongdan = UserConvert.convertInt(current.Id);
            //        dto.DiaChiDen = this.mDiachi;
            //        dto.GhiChu = "";
            //        dto.IdTruongCongAn = GlobalVariable.CurrentCongAnId;
            //        dto.LyDo = this.mLydo;
            //        dto.NgayBatDau = this.mNgayBatdau;
            //        dto.NgayKetThuc = this.mNgayKetthuc;
            //        dto.NgayLamDon = this.mNgayLamDon;


            //        tamVangDAO.insertTamVang(dto);
            //    }
            //    //save tam vang
            //    Constant.showDialog("Thêm tạm vắng thành công");
            //    this.NavigationService.Navigate(QuanlyTamVang.createInstance());
            //}


=======
            progressbar.Visibility = System.Windows.Visibility.Visible;
            await Task.Delay(500);
            await Task.Run(() => insertToDataBase());
            progressbar.Visibility = System.Windows.Visibility.Hidden;

            this.NavigationService.Navigate(QuanlyTamTru.createInstance());
>>>>>>> 66335c96dafe84bb49880aea9882ff27b7b01c13

        }

        private void insertToDataBase()
        {
            // save tam tru
            TamTruDAO tamTruDAO = new TamTruDAO();
            TamTruDTO dto = new TamTruDTO();
            dto.Active = 1;
            dto.IdCongdan = mIdCongDan;
            dto.DiachiDen = this.mDiachi;
            dto.Ghichu = "";
            dto.IdTruongCongan = GlobalVariable.CurrentCongAnId;
            dto.Lydo = this.mLydo;
            dto.NgayBatdau = this.mNgayBatdau;
            dto.NgayKetthuc = this.mNgayKetthuc;
            dto.NgayLamDon = this.mNgayLamDon;


            tamTruDAO.insertTamTru(dto);
            // save tom tat ban than
            TomTatBanThanDAO ttbtDAO = new TomTatBanThanDAO();
            TomTatBanThanDTO ttbtDTO = new TomTatBanThanDTO();
            foreach (SelectTamTruViewlModel current in mViewModel.ListTamTru)
            {
                ttbtDTO.Active = 1;
                ttbtDTO.ChoO = current.ChoO;
                ttbtDTO.Ghichu = current.GhiChu;
                ttbtDTO.IdCongdan = mIdCongDan;
                ttbtDTO.NgayBatdau = current.NgayBatDau;
                ttbtDTO.NgayKetthuc = current.NgayKetThuc;
                ttbtDTO.Nghenghiep = current.NgheNghiep;

                if (current.Id == null)
                {
                    ttbtDAO.insertTomTatBanThan(ttbtDTO);
                }
                else
                {
                    ttbtDTO.IdCongdan = Int32.Parse(current.Id);
                    ttbtDAO.updateTomTatBanThan(ttbtDTO);
                }
            }
        }



        private void onButtonAddClicked(object sender, RoutedEventArgs e)
        {
            if (mViewModel != null)
            {
                SelectTamTruViewlModel model = new SelectTamTruViewlModel();
                model.IdCongDan = mIdCongDan + "";
                model.NgayBatDau = DateTime.Now;
                model.NgayKetThuc = DateTime.Now.AddDays(1);
                mViewModel.ListTamTru.Add(model);
            }

        }

        private void onButtonRemoveClicked(object sender, RoutedEventArgs e)
        {
            if (table_household.SelectedIndex > -1)
            {
                mViewModel.ListTamTru.RemoveAt(table_household.SelectedIndex);
            }
        }

        private async void onButtonResetClicked(object sender, RoutedEventArgs e)
        {
            load();
        }

        private async void onLoaded(object sender, RoutedEventArgs e)
        {
            load();
        }

        private async void load()
        {
            progressbar.Visibility = System.Windows.Visibility.Visible;
            await Task.Delay(1000);
            mViewModel = new ThemTamTruPage2ViewModel(mIdCongDan);
            DataContext = mViewModel;
            progressbar.Visibility = System.Windows.Visibility.Hidden;
        }
<<<<<<< HEAD
=======

        private void ngayBatDau_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            (this.table_household.SelectedValue as SelectTamTruViewlModel).NgayBatDau = (sender as DatePicker).SelectedDate.Value;
        }
        private void ngayKetThuc_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime ngayBatDau = (this.table_household.SelectedValue as SelectTamTruViewlModel).NgayBatDau;
            DateTime ngayKetThuc = (sender as DatePicker).SelectedDate.Value;

            if (ngayBatDau >= ngayKetThuc)
            {
                Constant.showDialog("Ngày kết thúc phải lơn hơn ngày bắt đầu.");
                (this.table_household.SelectedValue as SelectTamTruViewlModel).NgayKetThuc = ngayBatDau.AddDays(1);
            }
        }
>>>>>>> 66335c96dafe84bb49880aea9882ff27b7b01c13
    }
}

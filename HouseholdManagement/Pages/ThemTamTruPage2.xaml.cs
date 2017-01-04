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
            progressbar.Visibility = System.Windows.Visibility.Visible;
            await Task.Delay(500);
            await Task.Run(() => insertToDataBase());
            progressbar.Visibility = System.Windows.Visibility.Hidden;

            //

            this.NavigationService.Navigate(QuanlyTamTru.createInstance());

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
                for (int i = table_household.SelectedItems.Count - 1; i >= 0; i--)
                {
                    mViewModel.ListTamTru.RemoveAt(i);
                }
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












    }
}

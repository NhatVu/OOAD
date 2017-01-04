using DataAcessLayer;
using DTO;
using HouseholdManagement.Utilities;
using HouseholdManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public partial class ThemTamVangPage1 : Page
    {
        private CongAnDTO mCongan;
        private ThemTamVangPage1ViewModel mViewModel;

        public static ThemTamVangPage1 createInstance(CongAnDTO congan)
        {
            return new ThemTamVangPage1(congan);
        }


        public ThemTamVangPage1(CongAnDTO congan)
        {

            InitializeComponent();
            this.mCongan = congan;
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

            int idCongAn = mCongan.Id;
            string lydo = textbox_lydo.Text.Trim();
            string diachi = textbox_diachi.Text.Trim();
            string ghichu = textbox_ghichu.Text.Trim();


            this.NavigationService.Navigate(ThemTamVangPage2.createInstance(idCongAn, lydo, diachi, ghichu, ngaybatdau, ngayketthuc, ngayLamDon));
        }

        private void onButtonCancelClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(QuanlyTamVang.createInstance());
        }

        private void onLoaded(object sender, RoutedEventArgs e)
        {
            mViewModel = new ThemTamVangPage1ViewModel(mCongan);
            DataContext = mViewModel;
            datepicker_ngaylamdon.SelectedDate = mViewModel.NgayLamDon;
            datepicker_ngaybatdau.BlackoutDates.AddDatesInPast();
            datepicker_ngayketthuc.BlackoutDates.AddDatesInPast();


        }
    }
}

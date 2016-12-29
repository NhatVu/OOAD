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

        public static ThemTamTruPage1 createInstance(CongAnDTO congan)
        {
            return new ThemTamTruPage1(congan);
        }


        public ThemTamTruPage1(CongAnDTO congan)
        {

            InitializeComponent();
            this.mCongan = congan;

        }

        private void onButtonNextClicked(object sender, RoutedEventArgs e)
        {

            
            if (textbox_diachi.Text.Trim().ToString().Count() == 0)
            {
                Constant.showDialog("Xin vui lòng nhập địa chỉ tạm trú");
                return;
            }

            if (textbox_lydo.Text.Trim().ToString().Count() == 0)
            {
                Constant.showDialog("Xin vui lòng nhập lý do tạm trú");
                return;
            }

            if (datepicker_ngaybatdau.SelectedDate == null || datepicker_ngayketthuc.SelectedDate == null)
            {
                Constant.showDialog("Xin vui lòng nhập ngày bắt đầu và ngày kết thúc");
                return;
            }

            DateTime ngaybatdau = DateTime.Parse(datepicker_ngaybatdau.SelectedDate.ToString());
            DateTime ngayketthuc = DateTime.Parse(datepicker_ngayketthuc.SelectedDate.ToString());

            if (ngayketthuc.Date < ngaybatdau.Date)
            {
                Constant.showDialog("Xin vui lòng nhập ngày kết thúc lớn hơn ngày bắt đầu");
                return;
            }

            int idCongAn = mCongan.Id;
            string lydo = textbox_lydo.Text.Trim();
            string diachi = textbox_diachi.Text.Trim();
            string ghichu = textbox_ghichu.Text.Trim();
            
            this.NavigationService.Navigate(ThemTamTruPage2.createInstance(idCongAn,lydo,diachi,ghichu,ngaybatdau,ngayketthuc));
        }

        private void onButtonCancelClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(QuanlyTamTru.createInstance());
        }

        private void onLoaded(object sender, RoutedEventArgs e)
        {
            mViewModel = new ThemTamTruPage1ViewModel(mCongan);
            DataContext = mViewModel;
            datepicker_ngaylamdon.SelectedDate = mViewModel.NgayLamDon;
            datepicker_ngaybatdau.BlackoutDates.AddDatesInPast();
            datepicker_ngayketthuc.BlackoutDates.AddDatesInPast();

            
        }
    }
}

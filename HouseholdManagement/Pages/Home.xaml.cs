
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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public static Home createInstance()
        {
            return new Home();
        }
        public Home()
        {
            InitializeComponent();
        }


        private void onButtonThemHoKhauClicked(object sender, RoutedEventArgs e)
        {
            replace(ThemHoKhauPage1.createInstance());
        }

        private void onButtonThemTamVangClicked(object sender, RoutedEventArgs e)
        {

        }

        private void onButtonThemTamTruNganHanClicked(object sender, RoutedEventArgs e)
        {

        }
        private void onButtonThemTamTruDaiHanClicked(object sender, RoutedEventArgs e)
        {

        }

        private void replace(Page page)
        {
            main_frame.Content = page;
        }

        private void item_thongtintaikhoan_Selected(object sender, RoutedEventArgs e)
        {
            replace(ThongTinTaiKhoan.createInstance());
        }

        private void item_thaydoimatkhau_Selected(object sender, RoutedEventArgs e)
        {
            replace(ThayDoiMatKhau.createInstance());
        }

        private void item_dangxuat_Selected(object sender, RoutedEventArgs e)
        {
            //dang xuat
        }

        private void item_quanlyhokhau_Selected(object sender, RoutedEventArgs e)
        {
            notLogin();
            replace(QuanlyHokhau.createInstance());
        }

        private void item_quanlytamtru_Selected(object sender, RoutedEventArgs e)
        {
            notLogin();
            replace(QuanlyTamTru.createInstance());
        }

        private void item_quanlytamvang_Selected(object sender, RoutedEventArgs e)
        {
            notLogin();
            replace(QuanlyTamVang.createInstance());
        }

        private void item_thongke_Selected(object sender, RoutedEventArgs e)
        {
            notLogin();
            replace(Thongke.createInstance());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listbox_main_menu.SelectedIndex = 0;
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {

        }

        private void thayDoiMatKhau_click(object sender, MouseButtonEventArgs e)
        {
            notLogin();
            replace(ThayDoiMatKhau.createInstance());
        }

        private void dangXuat_click(object sender, MouseButtonEventArgs e)
        {
            GlobalVariable.CurrentCongAnId = 0;
            this.NavigationService.Navigate(Login.createInstance());
        }

        private void notLogin()
        {
            if(GlobalVariable.CurrentCongAnId == 0)
                this.NavigationService.Navigate(Login.createInstance());
        }
    }
}

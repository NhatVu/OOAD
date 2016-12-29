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
    public partial class ThemHoKhauPage1 : Page
    {
        private static readonly string NAME = "ThemHoKhauPage2";
        private CongAnDTO mCongan;
        private ThemHoKhauPage1ViewModel mViewModel;
         
        public static ThemHoKhauPage1 createInstance(CongAnDTO congan)
        {
            return new ThemHoKhauPage1(congan);
        }


        public ThemHoKhauPage1(CongAnDTO congan)
        {
            
            InitializeComponent();
            this.mCongan = congan;
           
        }

        private void onButtonNextClicked(object sender, RoutedEventArgs e)
        {
            
            
            if (textbox_thuongchu.Text.Trim().ToString().Count() == 0)
                Constant.showDialog("Xin vui lòng nhập nơi đăng ký thường trú");
            else
            {

                HoKhauDTO hokhau = new HoKhauDTO(mCongan.Id, mViewModel.NoiLamViec, DateTime.Now,textbox_thuongchu.Text.Trim(), textbox_ghichu.Text.Trim(), 1);
                this.NavigationService.Navigate(ThemHoKhauPage2.createInstance(hokhau));
            }
            
        }

        private void onButtonCancelClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(QuanlyHokhau.createInstance());
        }

        private void onLoaded(object sender, RoutedEventArgs e)
        {
            mViewModel = new ThemHoKhauPage1ViewModel(mCongan);
            DataContext = mViewModel;
        }
    }
}

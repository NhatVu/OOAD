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
        public static ThemHoKhauPage1 createInstance()
        {
            return new ThemHoKhauPage1();
        }

        public ThemHoKhauPage1()
        {
            InitializeComponent();
        }

        private void onButtonNextClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(ThemHoKhauPage2.createInstance());
        }

        private void onButtonCancelClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(QuanlyHokhau.createInstance());
        }
    }
}

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
    public partial class ThemHoKhauPage2 : Page
    {
        public static ThemHoKhauPage2 createInstance()
        {
            return new ThemHoKhauPage2();
        }
        public ThemHoKhauPage2()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}

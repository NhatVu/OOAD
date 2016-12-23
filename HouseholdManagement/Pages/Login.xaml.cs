using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    /// 
    
    public partial class Login : Page
    {
        public static Login createInstance()
        {
            return new Login();
        }
        public Login()
        {
            InitializeComponent();
            handleEvents();       
        }

        private void handleEvents()
        {
            button_login.Click += new RoutedEventHandler(onLoginButtonClicked);
        }

        private void onLoginButtonClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(Home.createInstance());
        }
    }
}

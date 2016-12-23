
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
    /// Interaction logic for QuanlyTamTru.xaml
    /// </summary>
    public partial class QuanlyTamTru : Page
    {
        public static QuanlyTamTru createInstance()
        {
            return new QuanlyTamTru();
        }

        public QuanlyTamTru()
        {
            InitializeComponent();
        }

        private void onLoaded(object sender, RoutedEventArgs e)
        {
            loadData();
            handleEvent();
        }

        private void handleEvent()
        {
            
        }

        private void loadData()
        {
            
        }

        private void onUnloaded(object sender, RoutedEventArgs e)
        {
            //save data to database
            //do anything before close the door

        }



    }
}

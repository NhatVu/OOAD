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
using HouseholdManagement.ViewModels;
namespace HouseholdManagement.Pages
{
    /// <summary>
    /// Interaction logic for QuanlyTamVang.xaml
    /// </summary>
    public partial class QuanlyTamVang : Page
    {
    QuanLyTamVangViewModel viewMobel = null;
        public static QuanlyTamVang createInstance()
        {
            return new QuanlyTamVang();
        }



        public QuanlyTamVang()
        {
            InitializeComponent();
            viewMobel = QuanLyTamVangViewModel.createInstace();
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
            this.dataGird_QuanLyTamVang.ItemsSource = viewMobel.getTamVangAllInfo();
        }

        private void onUnloaded(object sender, RoutedEventArgs e)
        {
            //save data to database
            //do anything before close the door

        }

        private void Search_OnKeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}

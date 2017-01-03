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
using HouseholdManagement.Utilities;
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

        private async void loadData()
        {
            progressbar.Visibility = System.Windows.Visibility.Visible;
            await Task.Delay(1000);
            this.dataGird_QuanLyTamVang.ItemsSource = viewMobel.getTamVangAllInfo();
            progressbar.Visibility = System.Windows.Visibility.Hidden;
        }

        private void onUnloaded(object sender, RoutedEventArgs e)
        {
            //save data to database
            //do anything before close the door

        }

        private void Search_OnKeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Search_TextChange(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string query = textBox.Text;
            if(textBox.Equals(""))
                this.dataGird_QuanLyTamVang.ItemsSource = viewMobel.getTamVangAllInfo();
            else
                this.dataGird_QuanLyTamVang.ItemsSource = viewMobel.search(query);
        }

        private void mouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            QuanLyTamVangViewModel data = this.dataGird_QuanLyTamVang.SelectedItem as QuanLyTamVangViewModel;
            this.NavigationService.Navigate(ChinhSuaTamVangTamTru.createInstace(Constant.TYPE_CHINH_SUA_TAM_VANG, data));
        }
    }
}

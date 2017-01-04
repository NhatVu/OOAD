
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
    /// Interaction logic for QuanlyTamTru.xaml
    /// </summary>
    public partial class QuanlyTamTru : Page
    {
        QuanLyTamTruViewModel viewMobel = null;
        public static QuanlyTamTru createInstance()
        {
            return new QuanlyTamTru();
        }

        public QuanlyTamTru()
        {
            InitializeComponent();
            viewMobel = QuanLyTamTruViewModel.createInstace();
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
            this.dataGird_QuanLyTamTru.ItemsSource = viewMobel.getTamTruAllInfo();
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
            if(query.Equals(""))
                this.dataGird_QuanLyTamTru.ItemsSource = viewMobel.getTamTruAllInfo();
            else
                this.dataGird_QuanLyTamTru.ItemsSource = viewMobel.search(query);
        }

        private void button_detail_Click(object sender, RoutedEventArgs e)
        {
            QuanLyTamTruViewModel data = this.dataGird_QuanLyTamTru.SelectedItem as QuanLyTamTruViewModel;
            this.NavigationService.Navigate(ChinhSuaTamVangTamTru.createInstace(Constant.TYPE_CHINH_SUA_TAM_TRU, data));
        }


        private void row_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGird_QuanLyTamTru.SelectedItems.Count == 1 && dataGird_QuanLyTamTru.SelectedValue != null)
                button_detail.Visibility = System.Windows.Visibility.Visible;
            else
                button_detail.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}

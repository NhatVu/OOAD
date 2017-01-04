
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
    /// Interaction logic for QuanlyHokhau.xaml
    /// </summary>
    public partial class QuanlyHokhau : Page
    {
        public static QuanlyHokhau createInstance()
        {
            return new QuanlyHokhau();
        }

        public QuanlyHokhau()
        {
            InitializeComponent();
        }

        private void handleEvent()
        {

        }

        private async void loadData()
        {
            progressbar.Visibility = System.Windows.Visibility.Visible;
            await Task.Delay(1000);
            this.dataGrid_QuanLyHoKhau.ItemsSource = QuanlyHokhauViewModel.createInstance().getHoKhauAllInfo();
            progressbar.Visibility = System.Windows.Visibility.Hidden;
        }



        private void onLoaded(object sender, RoutedEventArgs e)
        {

            loadData();
            handleEvent();
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
            if (query.Equals(""))
                this.dataGrid_QuanLyHoKhau.ItemsSource = QuanlyHokhauViewModel.createInstance().getHoKhauAllInfo();
            else
                this.dataGrid_QuanLyHoKhau.ItemsSource = QuanlyHokhauViewModel.createInstance().search(query);
        }

        private void mouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void button_detail_Click(object sender, RoutedEventArgs e)
        {
            int hoKhauId = (this.dataGrid_QuanLyHoKhau.SelectedValue as QuanlyHokhauViewModel).Id;
            this.NavigationService.Navigate(ChiTietHoKhau.createInstance(hoKhauId));
        }

        private void row_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGrid_QuanLyHoKhau.SelectedItems.Count == 1 && dataGrid_QuanLyHoKhau.SelectedValue != null)
                button_detail.Visibility = System.Windows.Visibility.Visible;
            else
                button_detail.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
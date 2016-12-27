using DataAcessLayer;
using DTO;
using HouseholdManagement.UserControls;
using HouseholdManagement.Utilities;
using HouseholdManagement.ViewModels;
using MaterialDesignThemes.Wpf;
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
        private static readonly int ID = 0;
        private static readonly int CMND = 1;
        private static readonly int HOTEN = 2;

        private ThemHoKhauViewModel mViewModel;

        public static ThemHoKhauPage2 createInstance()
        {
            return new ThemHoKhauPage2();
        }
        public ThemHoKhauPage2()
        {
            InitializeComponent();
        }

        private void onButtonBackClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void onButtonSaveClicked(object sender, RoutedEventArgs e)
        {
            foreach(SelectableViewModel s in mViewModel.ListHoKhau)
            {
                MessageBox.Show(s.Id + s.Name + s.Ngaysinh + s.Cmnd + s.Gioitinh+s.GhiChu);
            }
        }

        private void table_household_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void onButtonAddClicked(object sender, RoutedEventArgs e)
        {
            mViewModel.ListHoKhau.Add(new SelectableViewModel());
        }

        private void onButtonRemoveClicked(object sender, RoutedEventArgs e)
        {
            mViewModel.ListHoKhau.RemoveAt(table_household.SelectedIndex);
        }

        private void onButtonSearchClicked(object sender, RoutedEventArgs e)
        {

        }

        private void onLoaded(object sender, RoutedEventArgs e)
        {
            mViewModel = new ThemHoKhauViewModel();
            DataContext = mViewModel;
        }

        private async void id_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = sender as ComboBox;
            int row = table_household.SelectedIndex;
            MessageBox.Show(box.Text);

            try
            {
                int value = int.Parse(box.SelectedValue + "");
                CongDanDTO congdan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectCongDanById(value))[0];

                string cmnd = (congdan.Cmnd != 0) ? (congdan.Cmnd + "") : "Chưa có";
                string hoten = congdan.HoTen;
                string ngaysinh = congdan.NgaySinh.ToString();
                string gioitinh = (congdan.GioiTinh == 0) ? "Nữ" : "Nam";

                mViewModel.ListHoKhau[row].Cmnd = cmnd;
                mViewModel.ListHoKhau[row].Gioitinh = gioitinh;
                mViewModel.ListHoKhau[row].Name = hoten;
                mViewModel.ListHoKhau[row].Ngaysinh = ngaysinh;
            }
            catch (FormatException ex)
            {
                var sampleMessageDialog = new SampleMessageDialog
                {
                    Message = { Text = "Mã số bạn nhập không tồn tại" }
                };

                await DialogHost.Show(sampleMessageDialog, "RootDialog");
            }





        }

        private void cmnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }

        private void ten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }
    }
}

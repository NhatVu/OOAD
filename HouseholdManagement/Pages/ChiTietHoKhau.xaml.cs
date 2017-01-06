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
using DTO;
using DataAcessLayer;
using HouseholdManagement.Utilities;

namespace HouseholdManagement.Pages
{
    /// <summary>
    /// Interaction logic for ChiTietHoKhau.xaml
    /// </summary>
    public partial class ChiTietHoKhau : Page
    {
        ChiTietHoKhauViewModel mViewModel = null;
        private static ChiTietHoKhau mInstance = null;
        private int hoKhauId = 0;
        public ChiTietHoKhau(int hoKhauId)
        {
            InitializeComponent();
            this.hoKhauId = hoKhauId;

        }

        public static ChiTietHoKhau createInstance(int hoKhauId)
        {
            return new ChiTietHoKhau(hoKhauId);
        }

        private async void onLoaded(object sender, RoutedEventArgs e)
        {
            mViewModel = new ChiTietHoKhauViewModel(this.hoKhauId);
            this.DataContext = mViewModel;
        }



        private async void onButtonSaveClicked(object sender, RoutedEventArgs e)
        {
            List<string> ids = new List<string>();
            ids.Clear();
            foreach (SelectHoKhauViewlModel row in mViewModel.ListChiTietHoKhau)
            {
                //MessageBox.Show(row.Id + row.Cmnd + row.Name + row.Quanhe + row.GhiChu);
                ids.Add(row.Id);
                if (row.Quanhe == null)
                {
                    Constant.showDialog("Tất cả quan hệ phải được điền");
                    return;
                }
            }
            bool isUnique = ids.Distinct().Count() == ids.Count();

            if (isUnique)
            {
                progressbar.Visibility = System.Windows.Visibility.Visible;
                await Task.Delay(500);
                await Task.Run(() => updateToDataBase());
                progressbar.Visibility = System.Windows.Visibility.Hidden;

                //

                this.NavigationService.Navigate(QuanlyHokhau.createInstance());
            }
            else
            {
                Constant.showDialog("Tất cả các thành viên phải khác nhau");
            }

        }

        private void updateToDataBase()
        {
            try
            {
                List<VaiTroSoHoKhauDTO> vaitro = Constant.DataTableToList<VaiTroSoHoKhauDTO>(new VaiTroSoHoKhauDAO().SelectAllVaiTroSoHoKhau());
                //int idHoKhau = mHoKhau.Id;
                foreach (SelectHoKhauViewlModel row in mViewModel.ListChiTietHoKhau)
                {
                    ChiTietHoKhauDTO chitietHoKhau = new ChiTietHoKhauDTO(this.hoKhauId,
                        int.Parse(row.Id),
                        vaitro.Find(x => x.TenVaitro == row.Quanhe).Id,
                        row.GhiChu,
                        1);
                    chitietHoKhau.Id = mViewModel.MapCongDanIdToChiTietHoKhauId[Int32.Parse(row.Id)];
                    new ChiTietHoKhauDAO().updateChiTietHoKhau(chitietHoKhau);
                }
            }
            finally
            {
             //   MessageBox.Show("Cập nhật hộ khẩu thành công");
            }
        }

        private void onButtonBackClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(QuanlyHokhau.createInstance());
        }
    }
}

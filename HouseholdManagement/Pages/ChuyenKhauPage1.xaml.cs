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
    public partial class ChuyenKhauPage1 : Page
    {
        private ChuyenKhauPage1ViewModel mViewModel;

        public static ChuyenKhauPage1 createInstance()
        {
            return new ChuyenKhauPage1();
        }
        public ChuyenKhauPage1()
        {
            InitializeComponent();
        }

        private void onButtonBackClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void onButtonNextClicked(object sender, RoutedEventArgs e)
        {
            //List<string> ids = new List<string>();
            //ids.Clear();
            //foreach (SelectHoKhauViewlModel row in mViewModel.ListHoKhau)
            //{
            //    //MessageBox.Show(row.Id + row.Cmnd + row.Name + row.Quanhe + row.GhiChu);
            //    ids.Add(row.Id);
            //    if (row.Quanhe == null)
            //    {
            //        Constant.showDialog("Tất cả quan hệ phải được điền");
            //        return;
            //    }
            //}
            //bool isUnique = ids.Distinct().Count() == ids.Count();

            //if (isUnique)
            //{
            //    progressbar.Visibility = System.Windows.Visibility.Visible;
            //    await Task.Delay(500);
            //    await Task.Run(() => insertToDataBase());
            //    progressbar.Visibility = System.Windows.Visibility.Hidden;

            //    //
                
            //    this.NavigationService.Navigate(QuanlyHokhau.createInstance());
            //}
            //else
            //{
            //    Constant.showDialog("Tất cả các thành viên phải khác nhau");
            //}

        }

        private void insertToDataBase()
        {
            //try
            //{
            //    int idHoKhau = new HoKhauDAO().insertHoKhau(mHoKhau);
            //    List<VaiTroSoHoKhauDTO> vaitro = Constant.DataTableToList<VaiTroSoHoKhauDTO>(new VaiTroSoHoKhauDAO().SelectAllVaiTroSoHoKhau());
            //    //int idHoKhau = mHoKhau.Id;
            //    foreach (SelectHoKhauViewlModel row in mViewModel.ListHoKhau)
            //    {
            //        ChiTietHoKhauDTO chitietHoKhau = new ChiTietHoKhauDTO(idHoKhau,
            //            int.Parse(row.Id),
            //            vaitro.Find(x => x.TenVaitro == row.Quanhe).Id,
            //            row.GhiChu,
            //            1);
            //        new ChiTietHoKhauDAO().insertChiTietHoKhau(chitietHoKhau);
            //    }
            //}finally
            //{
            //    MessageBox.Show("Thêm hộ khẩu thành công");
            //}
        }


        private async void onLoaded(object sender, RoutedEventArgs e)
        {
            progressbar.Visibility = System.Windows.Visibility.Visible;
            await Task.Delay(1000);
            mViewModel = new ChuyenKhauPage1ViewModel();
            DataContext = mViewModel;
            progressbar.Visibility = System.Windows.Visibility.Hidden;
        }

        private void idHoKhau_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = sender as ComboBox;
            int row = table_household.SelectedIndex;
            if (true)
            {
                try
                {

                    int value = int.Parse(box.SelectedValue + "");
                    List<ChiTietHoKhauDTO> ct = Constant.DataTableToList<ChiTietHoKhauDTO>(new ChiTietHoKhauDAO().SelectAllChiTietHoKhau());
                    if (ct != null)
                        updateTableRow(ct, row);
                }
                finally
                {
                    Constant.showDialog("Id bạn nhập không tồn tại");
                }
            }

        }

       
        private void updateTableRow(List<ChiTietHoKhauDTO> chitiet, int row)
        {
            for(int i = 0; i < chitiet.Count; i++)
            {
                ChiTietHoKhauDTO ct = chitiet[i];
                MessageBox.Show(ct.IdVaitroHokhau + "");
                string quanhe = mViewModel.ListQuanhe.FirstOrDefault(x => x.Id == ct.IdVaitroHokhau).TenVaitro;
                CongDanDTO congdan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectCongDanById(ct.IdCDThanhVien))[0];
                string id = congdan.Id + "";
                string cmnd = (congdan.Cmnd != 0) ? (congdan.Cmnd + "") : "Chưa có";
                string hoten = congdan.HoTen;
                string ngaysinh = congdan.NgaySinh.ToString("dd/MM/yyyy");
                string gioitinh = (congdan.GioiTinh == 0) ? "Nữ" : "Nam";
                string quequan = congdan.Quequan;

                mViewModel.ListCongDan.Add(new SelectCongDanViewModel());
                mViewModel.ListCongDan[i].Id = id;
                mViewModel.ListCongDan[i].Cmnd = cmnd;
                mViewModel.ListCongDan[i].Gioitinh = gioitinh;
                mViewModel.ListCongDan[i].Name = hoten;
                mViewModel.ListCongDan[i].Ngaysinh = ngaysinh;
                mViewModel.ListCongDan[i].Quanhe = quanhe;
            }
            
            

           
        }

        private void idHoKhau_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}

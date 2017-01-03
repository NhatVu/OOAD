using DataAcessLayer;
using DTO;
using HouseholdManagement.UserControls;
using HouseholdManagement.Utilities;
using HouseholdManagement.ViewModels;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using DTO;
using DataAcessLayer;

namespace HouseholdManagement.Pages
{
    /// <summary>
    /// Interaction logic for ThemHoKhauPage2.xaml
    /// </summary>
    public partial class ChuyenKhauPage2 : Page
    {
        private ChuyenKhauPage2ViewModel mViewModel;
        private ObservableCollection<SelectCongDanViewModel> mSelectedCongDan;
        private string lydo;
        private string ghichu;
        private int idHoKhauCu;

        public static ChuyenKhauPage2 createInstance(ObservableCollection<SelectCongDanViewModel> mSelectedCongDan, int idHoKhauCu,string lydo, string ghichu)
        {
            return new ChuyenKhauPage2(mSelectedCongDan, idHoKhauCu,lydo, ghichu);
        }
        public ChuyenKhauPage2(ObservableCollection<SelectCongDanViewModel> mSelectedCongDan, int idHoKhauCu,string lydo, string ghichu)
        {
            InitializeComponent();
            this.mSelectedCongDan = mSelectedCongDan;
            this.lydo = lydo;
            this.ghichu = ghichu;
            this.idHoKhauCu = idHoKhauCu;
        }

        private void onButtonBackClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private async void onButtonSaveClicked(object sender, RoutedEventArgs e)
        {
            // save to database
            int idHoKhauMoi = Int32.Parse(combobox_idHoKhau.SelectedValue.ToString());
            //kiểm tra xem chỉ có 1 chủ hộ đúng hok?
            List<string> ids = new List<string>();
            ids.Clear();
            foreach (SelectCongDanViewModel row in mViewModel.ListCongDan)
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
                await Task.Run(() => insertDatabase(idHoKhauMoi));
                progressbar.Visibility = System.Windows.Visibility.Hidden;

                //

                this.NavigationService.Navigate(QuanlyHokhau.createInstance());
            }
            else
            {
                Constant.showDialog("Tất cả các thành viên phải khác nhau");
            }

            // kiểm tra xem người dùng có chọn hộ khẩu nào không

            
            
            //mSelectedCongdan là TOÀN BỘ danh sách của page trước -> Kiểm tra xem cái nào .isSelected = true thì lấy ra

            //mViewModel.ListCongDan là listCongdan mới

            //mIdHoKhauCu ở trên

            //mIDHoKhauMoi = combobox_idHoKhau.SelectedValue
        }

        private void insertDatabase( int idHoKhauMoi)
        {
            ChuyenKhauDAO chuyenKhauDAO = new ChuyenKhauDAO();
            ChiTietHoKhauDAO chiTietHoKhauDAO = new ChiTietHoKhauDAO();
            
            foreach (SelectCongDanViewModel current in mSelectedCongDan)
            {
                if(current.IsSelected == false)
                    continue;
                int currentCongDanId = Int32.Parse(current.Id);
                int idVaiTroSoHoKhau = mViewModel.ListVaitro.FirstOrDefault(x => current.Quanhe.Equals(x.TenVaitro) == true).Id;
            // deactive công dân tại hộ khẩu cũ
                chiTietHoKhauDAO.DeactiveByCongDanIdAndHoKhauId(currentCongDanId, idHoKhauCu);
            // thêm công dân vào chi tiết hộ khẩu mới
                ChiTietHoKhauDTO chiTietHoKhauDTO = new ChiTietHoKhauDTO(idHoKhauMoi,currentCongDanId,idVaiTroSoHoKhau,ghichu,1);
                chiTietHoKhauDAO.insertChiTietHoKhau(chiTietHoKhauDTO);
            // thêm vào bảng chuyển khẩu
                ChuyenKhauDTO chuyenKhauDTO = new ChuyenKhauDTO(currentCongDanId, idHoKhauCu, idHoKhauMoi, lydo, idVaiTroSoHoKhau, ghichu, 1);
                chuyenKhauDAO.insertChuyenKhau(chuyenKhauDTO);
            }
           
        }

        private async void onLoaded(object sender, RoutedEventArgs e)
        {
            progressbar.Visibility = System.Windows.Visibility.Visible;
            await Task.Delay(1000);
            mViewModel = new ChuyenKhauPage2ViewModel();
            DataContext = mViewModel;
            mViewModel.ListIdHoKhau.Remove(idHoKhauCu);
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
                    List<ChiTietHoKhauDTO> chitiet = Constant.DataTableToList<ChiTietHoKhauDTO>(new ChiTietHoKhauDAO().SelectAllChiTietHoKhauByIdHoKhau(value));

                    if (chitiet != null)
                    {
                        if (mViewModel.ListCongDan.Count > 0)
                            mViewModel.ListCongDan = new ObservableCollection<SelectCongDanViewModel>();
                        mViewModel.IsAllItemSelected = false;

                        for (int i = 0; i < chitiet.Count; i++)
                        {
                            ChiTietHoKhauDTO ct = chitiet[i];
                            if (ct.IdVaiTroSoHoKhau != 1)
                            {
                                string quanhe = mViewModel.ListVaitro.FirstOrDefault(x => x.Id == ct.IdVaiTroSoHoKhau).TenVaitro;

                                CongDanDTO congdan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectCongDanById(ct.IdCDThanhVien))[0];
                                string id = congdan.Id + "";
                                string cmnd = (congdan.Cmnd != 0) ? (congdan.Cmnd + "") : "Chưa có";
                                string hoten = congdan.HoTen;
                                string ngaysinh = congdan.NgaySinh.ToString("dd/MM/yyyy");
                                string gioitinh = (congdan.GioiTinh == 0) ? "Nữ" : "Nam";
                                string quequan = congdan.Quequan;


                                mViewModel.ListCongDan.Add(new SelectCongDanViewModel());
                                int max = mViewModel.ListCongDan.Count - 1;
                                mViewModel.ListCongDan[max].Id = id;
                                mViewModel.ListCongDan[max].Cmnd = cmnd;
                                mViewModel.ListCongDan[max].Gioitinh = gioitinh;
                                mViewModel.ListCongDan[max].Name = hoten;
                                mViewModel.ListCongDan[max].Ngaysinh = ngaysinh;
                                mViewModel.ListCongDan[max].Quanhe = quanhe;
                            }
                        }

                        foreach(SelectCongDanViewModel view in mSelectedCongDan)
                        {
                            if (view.IsSelected == true)
                                mViewModel.ListCongDan.Add(view);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Constant.showDialog("Bạn đã nhập số hộ khẩu sai");
                }
            }
        }

        private void idHoKhau_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}

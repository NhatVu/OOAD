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
using DTO;
using DataAcessLayer;
using System.Data;

namespace HouseholdManagement.Pages
{
    /// <summary>
    /// Interaction logic for ChinhSuaTamVang.xaml
    /// </summary>
    public partial class ChinhSuaTamVangTamTru : Page
    {
        object data;
        TamVangDTO tamVangDTO = null;
        TamTruDTO tamTruDTO = null;
        TamVangDAO tamVangDAO = null;
        TamTruDAO tamTruDAO = null;
        int type;
        public ChinhSuaTamVangTamTru(int type, object data)
        {
            InitializeComponent();
            this.type = type;
            this.data = data;
        }

        public static ChinhSuaTamVangTamTru createInstace(int type, object data)
        {
            return new ChinhSuaTamVangTamTru(type, data);
        }

        private void onLoaded(object sender, RoutedEventArgs e)
        {
            switch (this.type)
            {
                case Constant.TYPE_CHINH_SUA_TAM_TRU:
                    tamTruDAO = new TamTruDAO();
                    DataTable tamTruSource = tamTruDAO.SelectTamTruById((this.data as QuanLyTamTruViewModel).Id);
                    List<TamTruDTO> tamTruList = Constant.DataTableToList<TamTruDTO>(tamTruSource);
                    tamTruDTO = tamTruList[0];
                    this.DataContext = this.data as QuanLyTamTruViewModel;
                    this.datepicker_ngaylamdon.SelectedDate = tamTruDTO.NgayLamDon;
                    this.textbox_diachi.Text = tamTruDTO.DiachiDen;
                    this.textbox_lydo.Text = tamTruDTO.Lydo;
                    break;
                case Constant.TYPE_CHINH_SUA_TAM_VANG:
                    tamVangDAO = new TamVangDAO();
                    DataTable tamVangSource = tamVangDAO.SelectTamVangById((this.data as QuanLyTamVangViewModel).Id);
                    List<TamVangDTO> tamVangList = Constant.DataTableToList<TamVangDTO>(tamVangSource);
                    tamVangDTO = tamVangList[0];
                    this.DataContext = this.data as QuanLyTamVangViewModel;
                    this.datepicker_ngaylamdon.SelectedDate = tamVangDTO.NgayLamDon;
                    this.textbox_diachi.Text = tamVangDTO.DiaChiDen;
                    this.textbox_lydo.Text = tamVangDTO.LyDo;
                    break;
            }
        }

        private void onButtonCancelClicked(object sender, RoutedEventArgs e)
        {
            if (this.type == Constant.TYPE_CHINH_SUA_TAM_VANG)
                this.NavigationService.Navigate(QuanlyTamVang.createInstance());
            else if (this.type == Constant.TYPE_CHINH_SUA_TAM_TRU)
                this.NavigationService.Navigate(QuanlyTamTru.createInstance());
        }
        private void onButtonSaveClicked(object sender, RoutedEventArgs e)
        {
            if (this.textbox_diachi.Text.Trim().ToString().Count() == 0)
            {
                Constant.showDialog("Xin vui lòng nhập địa chỉ tạm trú");
                return;
            }


            if (this.textbox_lydo.Text.Trim().ToString().Count() == 0)
            {
                Constant.showDialog("Xin vui lòng nhập lý do tạm trú");
                return;
            }
            if (datepicker_ngaybatdau.SelectedDate == null || datepicker_ngayketthuc.SelectedDate == null)
            {
                Constant.showDialog("Xin vui lòng nhập ngày bắt đầu và ngày kết thúc");
                return;
            }
            DateTime ngaybatdau = (DateTime)this.datepicker_ngaybatdau.SelectedDate;
            DateTime ngayketthuc = (DateTime)this.datepicker_ngayketthuc.SelectedDate;
            DateTime ngaylamdon = (DateTime)this.datepicker_ngaylamdon.SelectedDate;
           
            if (ngayketthuc.Date < ngaybatdau.Date)
            {
                Constant.showDialog("Xin vui lòng nhập ngày kết thúc lớn hơn ngày bắt đầu");
                return;
            }

            if (ngaylamdon.Date > ngaybatdau.Date)
            {
                Constant.showDialog("Xin vui lòng nhập ngày bắt đầu lớn hơn ngày làm đơn");
                return;
            }


            switch (this.type)
            {
                case Constant.TYPE_CHINH_SUA_TAM_TRU:
                    tamTruDTO.Lydo = this.textbox_lydo.Text;
                    tamTruDTO.NgayBatdau = ngaybatdau;
                    tamTruDTO.NgayKetthuc = ngayketthuc;
                    tamTruDTO.Ghichu = this.textbox_ghichu.Text;

                    tamTruDAO.updateTamTru(tamTruDTO);
                    this.NavigationService.Navigate(QuanlyTamTru.createInstance());
                    break;
                case Constant.TYPE_CHINH_SUA_TAM_VANG:
                    tamVangDTO.LyDo = this.textbox_lydo.Text;
                    tamVangDTO.NgayBatDau = ngaybatdau;
                    tamVangDTO.NgayKetThuc = ngayketthuc;
                    tamVangDTO.GhiChu = this.textbox_ghichu.Text;

                    tamVangDAO.updateTamVang(tamVangDTO);
                    this.NavigationService.Navigate(QuanlyTamVang.createInstance());

                    break;
            }
        }
    }
}

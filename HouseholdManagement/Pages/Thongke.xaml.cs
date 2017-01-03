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
using HouseholdManagement.Utilities;
using DataAcessLayer;

namespace HouseholdManagement.Pages
{
    /// <summary>
    /// Interaction logic for Thongke.xaml
    /// </summary>
    public partial class Thongke : Page
    {

        HoKhauDAO hoKhauDAO = null;
        TamTruDAO tamTruDAO = null;
        TamVangDAO tamVangDAO = null;
        public static Thongke createInstance()
        {
            return new Thongke();
        }


        public Thongke()
        {
            InitializeComponent();
            hoKhauDAO = new HoKhauDAO();
            tamTruDAO = new TamTruDAO();
            tamVangDAO = new TamVangDAO();
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
            int[] thang = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] nam = new int[20];
            nam[0] = DateTime.Now.Year;
            for (int i = 1; i < 20; i++)
                nam[i] = nam[i - 1] - 1;
            this.combobox_thang.ItemsSource = thang;
            this.comboxbox_nam.ItemsSource = nam;
        }

        private void onUnloaded(object sender, RoutedEventArgs e)
        {
            //save data to database
            //do anything before close the door

        }

        private void namThang_change(object sender, SelectionChangedEventArgs e)
        {
            if (this.combobox_thang.SelectedValue == null || this.comboxbox_nam.SelectedValue == null)
                return;
            int nam = Int32.Parse(this.comboxbox_nam.SelectedValue.ToString());
            int thang = Int32.Parse(this.combobox_thang.SelectedValue.ToString());

            Dictionary<string, string> thongKeHoKhau = hoKhauDAO.HoKhauThongKe(thang, nam);
            Dictionary<string, string> thongKeTamVang = tamVangDAO.TamVangThongKe(thang, nam);
            Dictionary<string, string> thongKeTamTru = tamTruDAO.TamTruThongKe(thang, nam);

            // binding source to component on ui
            //if (thongKeHoKhau == null || thongKeTamTru == null || thongKeTamVang == null)
            //    return;
            binding(thongKeHoKhau, thongKeTamTru, thongKeTamVang);
        }

        private void binding(Dictionary<string, string> thongKeHoKhau, Dictionary<string, string> thongKeTamTru, Dictionary<string, string> thongKeTamVang)
        {
            this.txt_tongHoKhau.Text = thongKeHoKhau["tongHoKhau"];
            this.txt_tongNhanKhau.Text = thongKeHoKhau["tongNhanKhau"];
            this.txt_tongNuGioi.Text = thongKeHoKhau["tongNuGioi"];
            this.txt_tongTrenMuoiBonBuoi.Text = thongKeHoKhau["tongTrenMuoiBonTuoi"];

            // tam tru
            this.txt_tamTruTong.Text = thongKeTamTru["tong"];
            this.txt_tamTruNu.Text = thongKeTamTru["tongNu"];
            this.txt_tamTruTrenMuoiBonTuoi.Text = thongKeTamTru["tongTrenMuoiBonTuoi"];

            // tam vang
            this.txt_tamVangTong.Text = thongKeTamVang["tong"];
            this.txt_tamVangNu.Text = thongKeTamVang["tongNu"];
            this.txt_tamVangTrenMuoiBonTuoi.Text = thongKeTamVang["tongTrenMuoiBonTuoi"];
        }
    }
}

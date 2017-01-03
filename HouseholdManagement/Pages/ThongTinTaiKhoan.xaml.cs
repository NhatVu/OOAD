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
using DTO;
using DataAcessLayer;
using HouseholdManagement.Utilities;
using System.Data;

namespace HouseholdManagement.Pages
{
    /// <summary>
    /// Interaction logic for ProfileOverview.xaml
    /// </summary>
    public partial class ThongTinTaiKhoan : Page
    {
        CongDanDAO congDanDAO = null;
        DanTocDAO danTocDAO = null;
        public static ThongTinTaiKhoan createInstance()
        {
            return new ThongTinTaiKhoan();
        }

        public ThongTinTaiKhoan()
        {
            InitializeComponent();
            congDanDAO = new CongDanDAO();
            danTocDAO = new DanTocDAO();
        }

        private void onLoaded(object sender, RoutedEventArgs e)
        {
            DataTable congDanSource = congDanDAO.SelectCongDanById(GlobalVariable.CurrentCongAnId);
            CongDanDTO dto = Constant.DataTableToList<CongDanDTO>(congDanSource)[0];
            DataTable danTocSource = danTocDAO.SelectDanTocById(dto.IdDantoc);
            this.DataContext = dto;
            this.gioiTinh.Text = (dto.GioiTinh == 0) ? "Nữ" : "Nam";
            this.textbox_danToc.Text = danTocSource.Rows[0]["tenDanToc"].ToString();
        }

    }
}

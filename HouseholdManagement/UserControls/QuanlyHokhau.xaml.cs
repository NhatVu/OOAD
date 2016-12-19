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

namespace HouseholdManagement.UserControls
{
    /// <summary>
    /// Interaction logic for QuanlyHokhau.xaml
    /// </summary>
    public partial class QuanlyHokhau : UserControl
    {
        public static QuanlyHokhau createInstance()
        {
            return new QuanlyHokhau();
        }

        public QuanlyHokhau()
        {
            InitializeComponent();
        }

        private void Search_OnKeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}

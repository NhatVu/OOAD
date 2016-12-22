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
    /// Interaction logic for Thongke.xaml
    /// </summary>
    public partial class Thongke : UserControl,IInstance
    {
        private static Thongke createInstance()
        {
            return new Thongke();
        }

        public object getInstance()
        {
            return Thongke.createInstance();
        }

        public Thongke()
        {
            InitializeComponent();
        }

        private void onLoaded(object sender, RoutedEventArgs e)
        {
            loadData();
            handleEvent();
        }

        private void handleEvent()
        {
            throw new NotImplementedException();
        }

        private void loadData()
        {
            throw new NotImplementedException();
        }

        private void onUnloaded(object sender, RoutedEventArgs e)
        {
            //save data to database
            //do anything before close the door

        }
    }
}

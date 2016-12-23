﻿
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

        private void loadData()
        {
            DataContext = new QuanlyHokhauViewModel();
            
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
    }
}
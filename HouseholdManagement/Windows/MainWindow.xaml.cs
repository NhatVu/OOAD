using HouseholdManagement.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace HouseholdManagement
{

    public partial class MainWindow : Window, Login.OnAuthenticatedSubmit
    {
        public MainWindow()
        {
            InitializeComponent();
            runSplashScreen();
        }

        public void onAuthenticateSubmited(bool isRight)
        {
            main_window_content.Content = Home.newInstance();
        }

        private void runSplashScreen()
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(Utilities.Constant.SPLASH_SCREEN_DURATION);
            }).ContinueWith(t =>
            {
                //note you can use the message queue from any thread, but just for the demo here we 
                //need to get the message queue from the snackbar, so need to be on the dispatcher
                main_window_content.Content = Login.createInstance();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}

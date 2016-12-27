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
using HouseholdManagement.Utilities;
using DataAcessLayer;
using DTO;
using System.Data;
using AutoMapper;
using HouseholdManagement.DataAccessLayers;

namespace HouseholdManagement.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    /// 
    
    public partial class Login : Page
    {
        CongAnDAO congDanDAO = null;
        public static Login createInstance()
        {
            
            return new Login();
        }
        public Login()
        {
            congDanDAO = new CongAnDAO();
            InitializeComponent();
            handleEvents();       
        }

        private void handleEvents()
        {
            button_login.Click += new RoutedEventHandler(onLoginButtonClicked);
        }

        private void onLoginButtonClicked(object sender, RoutedEventArgs e)
        {
           // init password
            //CongAnDTO congAnDTO = new CongAnDTO(3, "minhnhatse.uit@gmail.com", "Minh Nhat", null, null, 1);
            //congAnDTO.Password = PasswordHash.HashPassword("123456");

            // When login button click
            // valid email
            //textbox_email.Text = "minhnhatse.uit@gmail.com";
            //textbox_password.Password = "123456";
            if(CheckInput.IsEmail(textbox_email.Text)){
                DataTable congAnSource = congDanDAO.SelectCongAnByEmail(textbox_email.Text);
                if (congAnSource.Rows.Count == 0)
                {
                    MessageBox.Show("Email không tồn tại trong hệ thống. Vui lòng liên hệ với Admin để được cấp tài khoản");
                    return;
                }
                string password = congAnSource.Rows[0]["password"].ToString();

                if (PasswordHash.ValidatePassword(textbox_password.Password.ToString(), password)){
                    GlobalVariable.CurrentCongAnId = Int32.Parse(congAnSource.Rows[0]["id"].ToString());
                    //save if rememeber checkbox checked
                    if(checkbox_remember_password.IsChecked == true)
                    {
                        Constant.storeAccount(textbox_email.Text,textbox_password.Password);
                    }
                    else
                    {
                        Constant.storeAccount("","");
                    }

                    this.NavigationService.Navigate(Home.createInstance());
                }
                    // if login success
                else
                    MessageBox.Show("Password không đúng. Vui lòng nhập lại.");
            }
            else
            {
                MessageBox.Show("Xin hãy nhập địa chỉ email hợp lệ.");
            }  
        }


        private void onForgotPassword(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(QuenMatKhau.createInstance());
        }

        private void onLoaded(object sender, RoutedEventArgs e)
        {
            Account acc = Constant.getAccount();
            if (acc != null && acc.UserName.Length != 0 && acc.Password.Length != 0)
            {
                textbox_email.Text = acc.UserName;
                textbox_password.Password = acc.Password;
            }
        }
    }
}

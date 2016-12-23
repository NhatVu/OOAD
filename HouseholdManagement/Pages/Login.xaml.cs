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
            if(CheckInput.IsEmail(textbox_email.Text)){
                DataTable congAnSource = congDanDAO.SelectCongAnByEmail(textbox_email.Text);
                
                string password = congAnSource.Rows[0]["password"].ToString();

                if (PasswordHash.ValidatePassword(textbox_password.Password.ToString(), password))
                    // if login success
                    this.NavigationService.Navigate(Home.createInstance());
                else
                    MessageBox.Show("Password is incorrect");
            }
            else
            {
                MessageBox.Show("Please enter valid email");
            }
        
            


            
        }
    }
}

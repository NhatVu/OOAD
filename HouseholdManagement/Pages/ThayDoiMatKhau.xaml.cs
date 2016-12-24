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
using DTO;
using DataAcessLayer;
using System.Data;

namespace HouseholdManagement.Pages
{
    /// <summary>
    /// Interaction logic for ChangePassword.xaml
    /// </summary>
    public partial class ThayDoiMatKhau : Page
    {
        CongAnDAO congAnDAO = null;
        public static ThayDoiMatKhau createInstance()
        {
            return new ThayDoiMatKhau();
        }

        public ThayDoiMatKhau()
        {
            congAnDAO = new CongAnDAO();
            InitializeComponent();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            string mOldPassword = this.oldPassword.Password.ToString();
            string mNewPassword = this.newPassword.Password.ToString();

            DataTable congAnDT = congAnDAO.SelectCongAnById(GlobalVariable.CurrentCongAnId);
            CongAnDTO congAnDTO = new CongAnDTO();
            congAnDTO.Id = GlobalVariable.CurrentCongAnId;
            congAnDTO.Email = congAnDT.Rows[0]["email"].ToString();
            congAnDTO.Password = congAnDT.Rows[0]["password"].ToString();
            congAnDTO.Username = congAnDT.Rows[0]["username"].ToString();
            congAnDTO.Ghichu = congAnDT.Rows[0]["ghiChu"].ToString();
            congAnDTO.Active = Int32.Parse(congAnDT.Rows[0]["active"].ToString());
            
            // validate if oldPassword is correct
            if(PasswordHash.ValidatePassword(mOldPassword,congAnDTO.Password)){
                congAnDTO.Password  = PasswordHash.HashPassword(mNewPassword);
                congAnDAO.updateCongAn(congAnDTO);
                MessageBox.Show("Thay đổi mật khẩu thành công");
                
            }else{
                MessageBox.Show("Mật khẩu cũ không đúng. Hãy nhập lại.");
            }
        }
    }
}

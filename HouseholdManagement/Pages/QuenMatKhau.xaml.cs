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
using System.Net.Mail;
namespace HouseholdManagement.Pages
{
    /// <summary>
    /// Interaction logic for QuenMatKhau.xaml
    /// </summary>
    public partial class QuenMatKhau : Page
    {
        CongAnDAO congAnDAO = null;
        public static QuenMatKhau createInstance()
        {
            return new QuenMatKhau();
        }
        public QuenMatKhau()
        {
            congAnDAO = new CongAnDAO();
            InitializeComponent();
        }

        private void layLaiMatKhau_click(Object sender, RoutedEventArgs e)
        {
            string email = textbox_email.Text;
            if (CheckInput.IsEmail(email))
            {
                DataTable congAnSource = congAnDAO.SelectCongAnByEmail(email);
                CongAnDTO congAnDTO = new CongAnDTO();
                congAnDTO.Id = Int32.Parse(congAnSource.Rows[0]["Id"].ToString());
                congAnDTO.Email = congAnSource.Rows[0]["email"].ToString();
                congAnDTO.Password = congAnSource.Rows[0]["password"].ToString();
                congAnDTO.Username = congAnSource.Rows[0]["username"].ToString();
                congAnDTO.Ghichu = congAnSource.Rows[0]["ghiChu"].ToString();
                congAnDTO.Active = Int32.Parse(congAnSource.Rows[0]["active"].ToString());

                // generate new password
                string newPassword = System.IO.Path.GetRandomFileName();
                newPassword = newPassword.Replace(".", ""); // Remove period.
                sendNewPasswordViaEmail(congAnDTO, newPassword);
                
                // update new password
                congAnDTO.Password = PasswordHash.HashPassword(newPassword);
                congAnDAO.updateCongAn(congAnDTO);
                MessageBox.Show("Đã cấp lại mật khẩu. Vui lòng kiểm tra email.");
            }else
            MessageBox.Show("Email không chính xác, nhập lại email");
        }

        private void sendNewPasswordViaEmail(CongAnDTO congAnDTO, string newPassword)
        {
            try
            {

                SmtpClient mySmtpClient = new SmtpClient("smtp.gmail.com", 587);

                // set smtp-client with basicAuthentication
                mySmtpClient.UseDefaultCredentials = true;
                System.Net.NetworkCredential basicAuthenticationInfo = new
                   System.Net.NetworkCredential("mcq.mailserver@gmail.com", "mcq123456789");
                mySmtpClient.EnableSsl = true;
                mySmtpClient.Credentials = basicAuthenticationInfo;

                // add from,to mailaddresses
                MailAddress from = new MailAddress("mcq.mailserver@gmail.com", "Admin phần mềm Quản lý hộ khẩu");
                MailAddress to = new MailAddress(congAnDTO.Email, congAnDTO.Username);
                MailMessage myMail = new System.Net.Mail.MailMessage(from, to);

                // add ReplyTo
                //MailAddress replyto = new MailAddress("reply@example.com");
                //myMail.ReplyToList.Add(replyTo);

                // set subject and encoding
                myMail.Subject = "New Password";
                myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                // set body-message and encoding
                myMail.Body = "<p>Đây là password mới của bạn. Hãy thay đổi password sau khi đăng nhập để đảm bảo an toàn cho bản thân.</p><br><b>" + newPassword+"</b>";
                myMail.BodyEncoding = System.Text.Encoding.UTF8;
                // text or html
                myMail.IsBodyHtml = true;

                mySmtpClient.Send(myMail);
            }

            catch (SmtpException ex)
            {
                throw new ApplicationException
                  ("SmtpException has occured: " + ex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

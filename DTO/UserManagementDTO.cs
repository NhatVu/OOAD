using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserManagementDTO
    {
        private int Id { get; set; }
        private int IdRole { get; set; }
        private string Email { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        private string GhiChu { get; set; }
        private int Active { get; set; }
        public UserManagementDTO() { }

        public UserManagementDTO(int idRole, string username, string password, string ghiChu, int active)
        {
            this.IdRole = idRole;
            this.Username = username;
            this.Password = password;
            this.GhiChu = ghiChu;
            this.Active = active;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserManagementDTO
    {
        public int Id { get; set; }
        public int IdRole { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public UserManagementDTO() { }

        public UserManagementDTO(int idRole, string username, string password)
        {
            this.IdRole = idRole;
            this.Username = username;
            this.Password = password;
        }
    }
}

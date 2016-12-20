using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoleDTO
    {
        public string Id { get; set; }
        public string RoleName { get; set; }
        public string GhiChu { get; set; }
        public int Active { get; set; }
        public RoleDTO() { }

        public RoleDTO(string roleName, string ghiChu, int active)
        {
            this.RoleName = roleName;
            this.GhiChu = ghiChu;
            this.Active = active;
        }
    }
}

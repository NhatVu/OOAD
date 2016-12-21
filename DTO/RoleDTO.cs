using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoleDTO
    {
        private string Id { get; set; }
        private string RoleName { get; set; }
        private string GhiChu { get; set; }
        private int Active { get; set; }
        private RoleDTO() { }

        public RoleDTO(string roleName, string ghiChu, int active)
        {
            this.RoleName = roleName;
            this.GhiChu = ghiChu;
            this.Active = active;
        }
    }
}

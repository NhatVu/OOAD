using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class RoleDTO
    {
        public string Id { get; set; }
        public string RoleName { get; set; }

        public RoleDTO() { }

        public RoleDTO(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }
    }
}

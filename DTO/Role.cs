using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Role
    {
        public string Id { get; set; }
        public string RoleName { get; set; }

        public Role() { }

        public Role(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }
    }
}

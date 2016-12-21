using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAcessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class RoleBUS
    {
        RoleDAO obj = new RoleDAO();
        public bool insertRole(RoleDTO dto)
        {
            return obj.insertRole(dto);
        }

        public bool updateRole(RoleDTO dto)
        {
            return obj.updateRole(dto);
        }

        public bool deleteRole(int id)
        {
            return obj.deleteRole(id);
        }

        public DataTable SelectAllRole()
        {
            return obj.SelectAllRole();
        }
        public DataTable SelectRoleById(int id)
        {
            return obj.SelectRoleById(id);
        }
    }
}

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
    public class UserManagementBUS
    {
        UserManagementDAO obj = new UserManagementDAO();
        public bool insertUserManagement(UserManagementDTO dto)
        {
            return obj.insertUserManagement(dto);
        }

        public bool updateUserManagement(UserManagementDTO dto)
        {
            return obj.updateUserManagement(dto);
        }

        public bool deleteUserManagement(int id)
        {
            return obj.deleteUserManagement(id);
        }

        public DataTable SelectAllUserManagement()
        {
            return obj.SelectAllUserManagement();
        }
        public DataTable SelectUserManagementById(int id)
        {
            return obj.SelectUserManagementById(id);
        }
    }
}

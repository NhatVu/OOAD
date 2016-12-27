    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdManagement.DataAccessLayers
{
    public class Account
    {
        private readonly string userName;
        private readonly string password;

        public Account(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public string UserName
        {
            get
            {
                return userName;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
        }
    }
}

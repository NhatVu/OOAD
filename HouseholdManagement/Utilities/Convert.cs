using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdManagement.Utilities
{
    static class UserConvert
    {
        public static int convertInt(string goal)
        {
            try
            {
                return Int32.Parse(goal);
            }
            catch (Exception e)
            {
                return -1;
            }
        }


    }
}

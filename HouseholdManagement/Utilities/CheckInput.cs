using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdManagement.Utilities
{
    class CheckInput
    {
        public static bool isInt(string a)
        {
            try
            {
                Int32.Parse(a);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool isMax100(string a)
        {
            return a.Length < 100;
        }

        public static bool IsEmail(string emailaddress)
        {
            if (emailaddress.Length == 0)
                return false;
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}

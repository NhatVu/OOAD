using HouseholdManagement.DataAccessLayers;
using HouseholdManagement.UserControls;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HouseholdManagement.Utilities
{
    public static class Constant
    {

        public static readonly int SPLASH_SCREEN_DURATION = 1000;
        public static readonly int LOGIN_DURATION = 500;

        public static readonly int TYPE_THEM_TAM_TRU = 999;
        public static readonly int TYPE_THEM_TAM_VANG = 998;
        public const  int TYPE_CHINH_SUA_TAM_TRU = 997;
        public const int TYPE_CHINH_SUA_TAM_VANG = 996;

        private static readonly string FILE_NAME = "account.txt";

        public static void storeAccount(string username, string password)
        {
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(FILE_NAME, FileMode.Create, isoStore))
            {
                using (StreamWriter writer = new StreamWriter(isoStream))
                {
                    writer.WriteLine(Base64Encode(username));
                    writer.WriteLine(Base64Encode(password));
                }
            }
        }

        public static Account getAccount()
        {
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
            if (isoStore.FileExists(FILE_NAME))
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(FILE_NAME, FileMode.Open, isoStore))
                {
                    using (StreamReader reader = new StreamReader(isoStream))
                    {
                        string userName = reader.ReadLine();
                        string password = reader.ReadLine();
                        Account acc = new Account(Base64Decode(userName),Base64Decode(password));
                        return acc;
                    }
                }
            }
            return null;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static List<T> DataTableToList<T>(this DataTable table) where T : class, new()
        {
            try
            {
                List<T> list = new List<T>();

                foreach (var row in table.AsEnumerable())
                {
                    T obj = new T();

                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    list.Add(obj);
                }

                return list;
            }
            catch
            {
                return null;
            }
        }

        public static void showDialog(string message)
        {
            MessageBox.Show(message);
            
        }


    }

    
}

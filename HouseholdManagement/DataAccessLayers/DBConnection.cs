using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DataAcessLayer
{
    public class DBConnection
    {
        private static DBConnection mInstance = null;
        protected SqlConnection connection = null;
       // public string m_ConnectionString = @"Data Source=DESKTOP-6BBHNRT;Initial Catalog=QuanLyHoKhau;Integrated Security=True";
        private string m_ConnectionString = @"Data Source=DESKTOP-EK4JKJH;Initial Catalog=QuanLyHoKhau;Integrated Security=True";
        public DBConnection()
        {
            try
            {
                connection = new SqlConnection(m_ConnectionString);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DBConnection getInstance()
        {
            if (mInstance == null)
                mInstance = new DBConnection();
            return mInstance;
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}

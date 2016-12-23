using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DataAcessLayer
{
    public class CongAnDAO 
    {
        SqlConnection connection;
        public CongAnDAO() {
            connection = DBConnection.getInstance().getConnection();
        }

        public bool insertCongAn(CongAnDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "CongAn_Insert";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[6];
                parameter[0] = new SqlParameter("@id", dto.Id);
                parameter[1] = new SqlParameter("@email", dto.Email);
                parameter[2] = new SqlParameter("@username", dto.Username);
                parameter[3] = new SqlParameter("@password", dto.Password);
                parameter[4] = new SqlParameter("@ghiChu", dto.Ghichu);
                parameter[5] = new SqlParameter("@active", dto.Active);

                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }
        }

        public bool updateCongAn(CongAnDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "CongAn_UpdateById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[6];
                parameter[0] = new SqlParameter("@id", dto.Id);
                parameter[1] = new SqlParameter("@email", dto.Email);
                parameter[2] = new SqlParameter("@username", dto.Username);
                parameter[3] = new SqlParameter("@password", dto.Password);
                parameter[4] = new SqlParameter("@ghiChu", dto.Ghichu);
                parameter[5] = new SqlParameter("@active", dto.Active);

                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }
        }

        public bool deleteCongAn(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "CongAn_DeleteById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@id", id);


                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }
        }

        public DataTable SelectAllCongAn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "CongAn_SelectAll";
                command.CommandType = CommandType.StoredProcedure;

                //command.ExecuteNonQuery();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return null;
            }
        }

        public DataTable SelectCongAnById(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "CongAn_SelectById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@id", id);


                command.Parameters.AddRange(parameter);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return null;
            }
        }

        public DataTable SelectCongAnByEmail(string email)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "CongAn_SelectByEmail";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@email", email);


                command.Parameters.AddRange(parameter);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return null;
            }
        }
    }
}

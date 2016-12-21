using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
//Minhnhatnhat123
namespace DataAcessLayer
{
    public class ChuyenKhauDAO: DBConnection
    {
        public ChuyenKhauDAO() : base() { }

        public bool insertChuyenKhau(ChuyenKhauDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "ChuyenKhau_Insert";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[7];
                parameter[0] = new SqlParameter("@idCongDan", dto.IdCongdan);
                parameter[1] = new SqlParameter("@idHoKhauCu", dto.IdHokhauCu);
                parameter[2] = new SqlParameter("@idHoKhauMoi", dto.IdHokhauMoi);
                parameter[3] = new SqlParameter("@lyDo", dto.LyDo);
                parameter[4] = new SqlParameter("@idVaiTroSoHoKhau", dto.IdVaitroSoHokhau);
                parameter[5] = new SqlParameter("@ghiChu", dto.Ghichu);
                parameter[6] = new SqlParameter("@active", dto.Active);

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

        public bool updateChuyenKhau(ChuyenKhauDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "ChuyenKhau_UpdateById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[8];
                parameter[0] = new SqlParameter("@id", dto.Id);
                parameter[1] = new SqlParameter("@idCongDan", dto.IdCongdan);
                parameter[2] = new SqlParameter("@idHoKhauCu", dto.IdHokhauCu);
                parameter[3] = new SqlParameter("@idHoKhauMoi", dto.IdHokhauMoi);
                parameter[4] = new SqlParameter("@lyDo", dto.LyDo);
                parameter[5] = new SqlParameter("@idVaiTroSoHoKhau", dto.IdVaitroSoHokhau);
                parameter[6] = new SqlParameter("@ghiChu", dto.Ghichu);
                parameter[7] = new SqlParameter("@active", dto.Active);

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

        public bool deleteChuyenKhau(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "ChuyenKhau_DeleteById";
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

        public DataTable SelectAllChuyenKhau()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "ChuyenKhau_SelectAll";
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

        public DataTable SelectChuyenKhauById(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "ChuyenKhau_SelectById";
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
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAcessLayer
{
    public class HoKhauDAO : DBConnection
    {
        public HoKhauDAO() : base() { }

        public int insertHoKhau(HoKhauDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "HoKhau_Insert";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[6];
                parameter[0] = new SqlParameter("@idCDTruongCongAn", dto.IdCDTruongCongAn);
                parameter[1] = new SqlParameter("@noiCap", dto.NoiCap);
                parameter[2] = new SqlParameter("@noiDangKyThuongTru", dto.NoiDangKyThuongTru);
                parameter[3] = new SqlParameter("@ghiChu", dto.GhiChu);
                parameter[4] = new SqlParameter("@active", dto.Active);
                parameter[5] = new SqlParameter("@ngayCap", dto.NgayCap);
             

                command.Parameters.AddRange(parameter);
                int id = (int)command.ExecuteScalar();
                connection.Close();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return 0;
            }
        }

        public bool updateHoKhau(HoKhauDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "HoKhau_UpdateById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[7];
                parameter[0] = new SqlParameter("@id", dto.Id);
                parameter[1] = new SqlParameter("@idCDTruongCongAn", dto.IdCDTruongCongAn);
                parameter[2] = new SqlParameter("@noiCap", dto.NoiCap);
                parameter[3] = new SqlParameter("@noiDangKyThuongTru", dto.NoiDangKyThuongTru);
                parameter[4] = new SqlParameter("@ghiChu", dto.GhiChu);
                parameter[5] = new SqlParameter("@active", dto.Active);
                parameter[6] = new SqlParameter("@ngayCap", dto.NgayCap);

               

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

        public bool deleteHoKhau(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "HoKhau_DeleteById";
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

        public DataTable SelectAllHoKhau()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "HoKhau_SelectAll";
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

        public DataTable SelectHoKhauById(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "HoKhau_SelectById";
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

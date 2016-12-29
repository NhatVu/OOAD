using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HouseholdManagement.Utilities;

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

        public DataTable GetAllInfo()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "HoKhau_GetAllInfo";
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

        public DataTable HoKhauSearch(string query)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "HoKhau_Search";
                command.CommandType = CommandType.StoredProcedure;
                // @idCD int=null, @cmnd int=null, @hoTenChuHo nvarchar(50)=null, @cmndCA int=null,@hoTenCongAn nvarchar(50)=null, @noiCap nvarchar(300) =null

                SqlParameter[] parameter;
                parameter = new SqlParameter[6];
                parameter[0] = new SqlParameter("@idCD", UserConvert.convertInt(query));
                parameter[1] = new SqlParameter("@cmnd", UserConvert.convertInt(query));
                parameter[2] = new SqlParameter("@hoTenChuHo", query);
                parameter[3] = new SqlParameter("@cmndCA", UserConvert.convertInt(query));
                parameter[4] = new SqlParameter("@hoTenCongAn", query);
                parameter[5] = new SqlParameter("@noiCap", query);

                command.Parameters.AddRange(parameter);
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
    }
}

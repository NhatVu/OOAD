using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using HouseholdManagement.Utilities;


namespace DataAcessLayer
{
    public class TamVangDAO : DBConnection
    {
        public TamVangDAO() : base() { }

        public bool insertTamVang(TamVangDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "TamVang_Insert";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[9];
                parameter[0] = new SqlParameter("@idCongDan", dto.IdCongdan);
                parameter[1] = new SqlParameter("@idTruongCongAn", dto.IdTruongCongAn);
                parameter[2] = new SqlParameter("@ngayBatDau", dto.NgayBatDau);
                parameter[3] = new SqlParameter("@ngayKetThuc", dto.NgayKetThuc);
                parameter[4] = new SqlParameter("@lyDo", dto.LyDo);
                parameter[5] = new SqlParameter("@diaChiDen", dto.DiaChiDen);
                parameter[6] = new SqlParameter("@ngayLamDon", dto.NgayLamDon);
                parameter[7] = new SqlParameter("@ghiChu", dto.GhiChu);
                parameter[8] = new SqlParameter("@active", dto.Active);

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

        public bool updateTamVang(TamVangDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "TamVang_UpdateById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[10];
                parameter[0] = new SqlParameter("@id", dto.Id);
                parameter[1] = new SqlParameter("@idCongDan", dto.IdCongdan);
                parameter[2] = new SqlParameter("@idTruongCongAn", dto.IdTruongCongAn);
                parameter[3] = new SqlParameter("@ngayBatDau", dto.NgayBatDau);
                parameter[4] = new SqlParameter("@ngayKetThuc", dto.NgayKetThuc);
                parameter[5] = new SqlParameter("@lyDo", dto.LyDo);
                parameter[6] = new SqlParameter("@diaChiDen", dto.DiaChiDen);
                parameter[7] = new SqlParameter("@ngayLamDon", dto.NgayLamDon);
                parameter[8] = new SqlParameter("@ghiChu", dto.GhiChu);
                parameter[9] = new SqlParameter("@active", dto.Active);

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

        public bool deleteTamVang(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "TamVang_DeleteById";
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

        public DataTable SelectAllTamVang()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "TamVang_SelectAll";
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

        public DataTable SelectTamVangById(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "TamVang_SelectById";
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
                command.CommandText = "TamVang_GetAllInfo";
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

        public DataTable TamVangSearch(string query)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "TamVang_Search";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[3];
                parameter[0] = new SqlParameter("@idCD", UserConvert.convertInt(query));
                parameter[1] = new SqlParameter("@cmnd", UserConvert.convertInt(query));
                parameter[2] = new SqlParameter("@hoTen", query);

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

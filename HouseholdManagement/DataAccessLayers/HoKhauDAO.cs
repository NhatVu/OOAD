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

        public bool insertHoKhau(HoKhauDTO dto)
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
                parameter = new SqlParameter[5];
                parameter[0] = new SqlParameter("@idCDTruongCongAn", dto.IdCDTruongCongAn);
                parameter[1] = new SqlParameter("@noiCap", dto.NoiCap);
                parameter[2] = new SqlParameter("@noiDangKyThuongTru", dto.NoiDangKyThuongTru);
                parameter[3] = new SqlParameter("@ghiChu", dto.GhiChu);
                parameter[4] = new SqlParameter("@active", dto.Active);
             

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
                parameter = new SqlParameter[6];
                parameter[0] = new SqlParameter("@id", dto.Id);
                parameter[1] = new SqlParameter("@idCDTruongCongAn", dto.IdCDTruongCongAn);
                parameter[2] = new SqlParameter("@noiCap", dto.NoiCap);
                parameter[3] = new SqlParameter("@noiDangKyThuongTru", dto.NoiDangKyThuongTru);
                parameter[4] = new SqlParameter("@ghiChu", dto.GhiChu);
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
    }
}

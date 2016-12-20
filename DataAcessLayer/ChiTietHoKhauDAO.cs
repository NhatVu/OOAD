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
    public class ChiTietHoKhauDAO: DBConnection
    {
        public ChiTietHoKhauDAO() : base() { }

        public bool insertChiTietHoKhau(ChiTietHoKhauDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "ChiTietHoKhau_Insert";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[6];
                parameter[0] = new SqlParameter("@idHoKhau", dto.IdHoKhau);
                parameter[1] = new SqlParameter("@idCDThanhVien", dto.IdCDThanhVien);
                parameter[2] = new SqlParameter("@idVaiTroSoHoKhau", dto.IdVaiTroSoHoKhau);
                parameter[3] = new SqlParameter("@ghiChu", dto.GhiChu);
                parameter[4] = new SqlParameter("@active", dto.Active);
                parameter[5] = new SqlParameter("@idKSThanhVien", dto.IDKSThanhVien);

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

        public bool updateChiTietHoKhau(ChiTietHoKhauDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "ChiTietHoKhau_UpdateById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[7];
                parameter[0] = new SqlParameter("@id", dto.Id);
                parameter[1] = new SqlParameter("@idHoKhau", dto.IdHoKhau);
                parameter[2] = new SqlParameter("@idCDThanhVien", dto.IdCDThanhVien);
                parameter[3] = new SqlParameter("@idVaiTroSoHoKhau", dto.IdVaiTroSoHoKhau);
                parameter[4] = new SqlParameter("@idKSThanhVIen", dto.IDKSThanhVien);
                parameter[5] = new SqlParameter("@ghiChu", dto.GhiChu);
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

        public bool deleteChiTietHoKhau(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "ChiTietHoKhau_DeleteById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[4];
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

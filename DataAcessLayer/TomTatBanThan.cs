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
    public class TomTatBanThanDAO : DBConnection
    {
        public TomTatBanThanDAO() : base() { }

        public bool insertTomTatBanThan(TomTatBanThanDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "TomTatBanThan_Insert";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[5];
                parameter[0] = new SqlParameter("@idCongDan", dto.IdCongDan);
                parameter[1] = new SqlParameter("@ngayBatDau", dto.NgayBatDau);
                parameter[2] = new SqlParameter("@ngayKetThuc", dto.NgayKetThuc);
                parameter[3] = new SqlParameter("@choO", dto.ChoO);
                parameter[4] = new SqlParameter("@ngheNghiep", dto.NgheNghiep);

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

        public bool updateTomTatBanThan(TomTatBanThanDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "TomTatBanThan_UpdateById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[6];
                parameter[0] = new SqlParameter("@id", dto.Id);
                parameter[1] = new SqlParameter("@idCongDan", dto.IdCongDan);
                parameter[2] = new SqlParameter("@ngayBatDau", dto.NgayBatDau);
                parameter[3] = new SqlParameter("@ngayKetThuc", dto.NgayKetThuc);
                parameter[4] = new SqlParameter("@choO", dto.ChoO);
                parameter[5] = new SqlParameter("@ngheNghiep", dto.NgheNghiep);

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

        public bool deleteTomTatBanThan(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "TomTatBanThan_DeleteById";
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

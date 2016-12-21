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
    public class TienAnDAO : DBConnection
    {
        public TienAnDAO() : base() { }

        public bool insertTienAn(TienAnDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "TienAn_Insert";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[7];
                parameter[0] = new SqlParameter("@idCongDan", dto.IdCongdan);
                parameter[1] = new SqlParameter("@toiDanh", dto.Toidanh);
                parameter[2] = new SqlParameter("@hinhPhat", dto.Hinhphat);
                parameter[3] = new SqlParameter("@ngayThang", dto.NgayThang);
                parameter[4] = new SqlParameter("@noiTuyenAn", dto.NoiTuyenAn);
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

        public bool updateTienAn(TienAnDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "TienAn_UpdateById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[8];
                parameter[0] = new SqlParameter("@id", dto.Id);
                parameter[1] = new SqlParameter("@idCongDan", dto.IdCongdan);
                parameter[2] = new SqlParameter("@toiDanh", dto.Toidanh);
                parameter[3] = new SqlParameter("@hinhPhat", dto.Hinhphat);
                parameter[4] = new SqlParameter("@ngayThang", dto.NgayThang);
                parameter[5] = new SqlParameter("@noiTuyenAn", dto.NoiTuyenAn);
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

        public bool deleteTienAn(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "TienAn_DeleteById";
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

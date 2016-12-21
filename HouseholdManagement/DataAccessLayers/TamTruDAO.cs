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
    public class TamTruDAO : DBConnection
    {
        public TamTruDAO() : base() { }

        public bool insertTamTru(TamTruDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "TamTru_Insert";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[9];
                parameter[0] = new SqlParameter("@idCongDan", dto.IdCongdan);
                parameter[1] = new SqlParameter("@idTruongCongAn", dto.IdTruongCongan);
                parameter[2] = new SqlParameter("@ngayBatDau", dto.NgayBatdau);
                parameter[3] = new SqlParameter("@ngayKetThuc", dto.NgayKetthuc);
                parameter[4] = new SqlParameter("@lyDo", dto.Lydo);
                parameter[5] = new SqlParameter("@diaChiDen", dto.DiachiDen);
                parameter[6] = new SqlParameter("@ngayLamDon", dto.NgayLamDon);
                parameter[7] = new SqlParameter("@ghiChu", dto.Ghichu);
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

        public bool updateTamTru(TamTruDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "TamTru_UpdateById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[10];
                parameter[0] = new SqlParameter("@id", dto.Id);
                parameter[1] = new SqlParameter("@idCongDan", dto.IdCongdan);
                parameter[2] = new SqlParameter("@idTruongCongAn", dto.IdTruongCongan);
                parameter[3] = new SqlParameter("@ngayBatDau", dto.NgayBatdau);
                parameter[4] = new SqlParameter("@ngayKetThuc", dto.NgayKetthuc);
                parameter[5] = new SqlParameter("@lyDo", dto.Lydo);
                parameter[6] = new SqlParameter("@diaChiDen", dto.DiachiDen);
                parameter[7] = new SqlParameter("@ngayLamDon", dto.NgayLamDon);
                parameter[8] = new SqlParameter("@ghiChu", dto.Ghichu);
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

        public bool deleteTamTru(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "TamTru_DeleteById";
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

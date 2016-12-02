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
    public class KhaiSinhDAO : DBConnection
    {
        public KhaiSinhDAO() : base() { }

        public bool insertKhaiSinh(KhaiSinhDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "KhaiSinh_Insert";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[12];
                parameter[0] = new SqlParameter("@idDanToc", dto.IdDanToc);
                parameter[1] = new SqlParameter("@hoTen", dto.HoTen);
                parameter[2] = new SqlParameter("@ngaySinh", dto.NgaySinh);
                parameter[3] = new SqlParameter("@gioiTinh", dto.GioiTinh);
                parameter[4] = new SqlParameter("@queQuan", dto.QueQuan);
                parameter[5] = new SqlParameter("@quocTich", dto.QuocTich);
                parameter[6] = new SqlParameter("@idKhaiSinhCha", dto.IdKhaiSinhCha);
                parameter[7] = new SqlParameter("@idKhaiSinhMe", dto.IdKhaiSinhMe);
                parameter[8] = new SqlParameter("@noiDangKy", dto.NoiDangKy);
                parameter[9] = new SqlParameter("@ngayDangKy", dto.NgayDangKy);
                parameter[10] = new SqlParameter("@idNguoiLamDon", dto.IdNguoiLamDon);
                parameter[11] = new SqlParameter("@idNguoiKy", dto.idNguoiKy);


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

        public bool updateKhaiSinh(KhaiSinhDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "KhaiSinh_UpdateById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[13];
                parameter[0] = new SqlParameter("@id", dto.Id);
                parameter[1] = new SqlParameter("@idDanToc", dto.IdDanToc);
                parameter[2] = new SqlParameter("@hoTen", dto.HoTen);
                parameter[3] = new SqlParameter("@ngaySinh", dto.NgaySinh);
                parameter[4] = new SqlParameter("@gioiTinh", dto.GioiTinh);
                parameter[5] = new SqlParameter("@queQuan", dto.QueQuan);
                parameter[6] = new SqlParameter("@quocTich", dto.QuocTich);
                parameter[7] = new SqlParameter("@idKhaiSinhCha", dto.IdKhaiSinhCha);
                parameter[8] = new SqlParameter("@idKhaiSinhMe", dto.IdKhaiSinhMe);
                parameter[9] = new SqlParameter("@noiDangKy", dto.NoiDangKy);
                parameter[10] = new SqlParameter("@ngayDangKy", dto.NgayDangKy);
                parameter[11] = new SqlParameter("@idNguoiLamDon", dto.IdNguoiLamDon);
                parameter[12] = new SqlParameter("@idNguoiKy", dto.idNguoiKy);

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

        public bool deleteKhaiSinh(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "KhaiSinh_DeleteById";
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

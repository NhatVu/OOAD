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
                parameter = new SqlParameter[14];
                parameter[0] = new SqlParameter("@idDanToc", dto.IdDantoc);
                parameter[1] = new SqlParameter("@hoTen", dto.HoTen);
                parameter[2] = new SqlParameter("@ngaySinh", dto.Ngaysinh);
                parameter[3] = new SqlParameter("@gioiTinh", dto.Gioitinh);
                parameter[4] = new SqlParameter("@queQuan", dto.Quequan);
                parameter[5] = new SqlParameter("@quocTich", dto.Quoctich);
                parameter[6] = new SqlParameter("@idCDCha", dto.IdCDCha);
                parameter[7] = new SqlParameter("@idCDMe", dto.IdCDMe);
                parameter[8] = new SqlParameter("@noiDangKy", dto.NoiDangky);
                parameter[9] = new SqlParameter("@ngayDangKy", dto.NgayDangky);
                parameter[10] = new SqlParameter("@idNguoiLamDon", dto.IdNguoiLamDon);
                parameter[11] = new SqlParameter("@idCDNguoiKy", dto.IdCDNguoiKy);
                parameter[12] = new SqlParameter("@ghiChu", dto.Ghichu);
                parameter[13] = new SqlParameter("@active", dto.Active);

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
                parameter = new SqlParameter[15];
                parameter[0] = new SqlParameter("@id", dto.Id);
                parameter[1] = new SqlParameter("@idDanToc", dto.IdDantoc);
                parameter[2] = new SqlParameter("@hoTen", dto.HoTen);
                parameter[3] = new SqlParameter("@ngaySinh", dto.Ngaysinh);
                parameter[4] = new SqlParameter("@gioiTinh", dto.Gioitinh);
                parameter[5] = new SqlParameter("@queQuan", dto.Quequan);
                parameter[6] = new SqlParameter("@quocTich", dto.Quoctich);
                parameter[7] = new SqlParameter("@idCDCha", dto.IdCDCha);
                parameter[8] = new SqlParameter("@idCDhMe", dto.IdCDMe);
                parameter[9] = new SqlParameter("@noiDangKy", dto.NoiDangky);
                parameter[10] = new SqlParameter("@ngayDangKy", dto.NgayDangky);
                parameter[11] = new SqlParameter("@idNguoiLamDon", dto.IdNguoiLamDon);
                parameter[12] = new SqlParameter("@idCDNguoiKy", dto.IdCDNguoiKy);
                parameter[13] = new SqlParameter("@ghiChu", dto.Ghichu);
                parameter[14] = new SqlParameter("@active", dto.Active);

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

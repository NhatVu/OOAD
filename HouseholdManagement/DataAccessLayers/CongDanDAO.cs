using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Minhnhatnhat000
namespace DataAcessLayer
{
    public class CongDanDAO : DBConnection
    {
        public CongDanDAO() : base() {  }

        public bool insertCongDan(CongDanDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "CongDan_Insert";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[22];
                parameter[0] = new SqlParameter("@idDanToc", dto.IdDantoc);
                parameter[1] = new SqlParameter("@hoTen", dto.HoTen);
                parameter[2] = new SqlParameter("@ngaySinh", dto.HoTen);
                parameter[3] = new SqlParameter("@gioiTinh", dto.GioiTinh);
                parameter[4] = new SqlParameter("@queQuan", dto.Quequan);
                parameter[5] = new SqlParameter("@quocTich", dto.Quoctich);
                parameter[6] = new SqlParameter("@noiDangKyKS", dto.NoiDangkyKS);
                parameter[7] = new SqlParameter("@ngayDangKyKS", dto.NgayDangkyKS);
                parameter[8] = new SqlParameter("@idNguoiLamDonKS", dto.NguoiLamDonKS);
                parameter[9] = new SqlParameter("@idCDNguoiKyKS", dto.NguoiKyKS);
                parameter[10] = new SqlParameter("@cmnd", dto.Cmnd);
                parameter[11] = new SqlParameter("@tonGiao", dto.Tongiao);
                parameter[12] = new SqlParameter("@ngheNghiep", dto.Nghenghiep);
                parameter[13] = new SqlParameter("@noiLamViec", dto.NoiLamViec);
                parameter[14] = new SqlParameter("@ngayCapCMND", dto.NgayCapCMND);
                parameter[15] = new SqlParameter("@noiCap", dto.NoiCap);
                parameter[16] = new SqlParameter("@diaChiThuongTru", dto.DiachiThuongtru);
                parameter[17] = new SqlParameter("@trinhDoHocVan", dto.TrinhDoHocVan);
                parameter[18] = new SqlParameter("@trinhDoChuyenMon", dto.TrinhdoChuyenmon);
                parameter[19] = new SqlParameter("@trinhDoNgoaiNgu", dto.TrinhdoNgoaingu);
                parameter[20] = new SqlParameter("@ghiChu", dto.Ghichu);
                parameter[21] = new SqlParameter("@active", dto.Active);

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

        public bool updateCongDan(CongDanDTO dto)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "CongDan_UpdateById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[23];
                parameter[0] = new SqlParameter("@idDanToc", dto.Id);
                parameter[1] = new SqlParameter("@idDanToc", dto.IdDantoc);
                parameter[2] = new SqlParameter("@hoTen", dto.HoTen);
                parameter[3] = new SqlParameter("@ngaySinh", dto.HoTen);
                parameter[4] = new SqlParameter("@gioiTinh", dto.GioiTinh);
                parameter[5] = new SqlParameter("@queQuan", dto.Quequan);
                parameter[6] = new SqlParameter("@quocTich", dto.Quoctich);
                parameter[7] = new SqlParameter("@noiDangKyKS", dto.NoiDangkyKS);
                parameter[8] = new SqlParameter("@ngayDangKyKS", dto.NgayDangkyKS);
                parameter[9] = new SqlParameter("@idNguoiLamDonKS", dto.NguoiLamDonKS);
                parameter[10] = new SqlParameter("@idCDNguoiKyKS", dto.NguoiKyKS);
                parameter[11] = new SqlParameter("@cmnd", dto.Cmnd);
                parameter[12] = new SqlParameter("@tonGiao", dto.Tongiao);
                parameter[13] = new SqlParameter("@ngheNghiep", dto.Nghenghiep);
                parameter[14] = new SqlParameter("@noiLamViec", dto.NoiLamViec);
                parameter[15] = new SqlParameter("@ngayCapCMND", dto.NgayCapCMND);
                parameter[16] = new SqlParameter("@noiCap", dto.NoiCap);
                parameter[17] = new SqlParameter("@diaChiThuongTru", dto.DiachiThuongtru);
                parameter[18] = new SqlParameter("@trinhDoHocVan", dto.TrinhDoHocVan);
                parameter[19] = new SqlParameter("@trinhDoChuyenMon", dto.TrinhdoChuyenmon);
                parameter[20] = new SqlParameter("@trinhDoNgoaiNgu", dto.TrinhdoNgoaingu);
                parameter[21] = new SqlParameter("@ghiChu", dto.Ghichu);
                parameter[22] = new SqlParameter("@active", dto.Active);

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

        public bool deleteCongDan(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "CongDan_DeleteById";
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

        public DataTable SelectAllCongDan()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "CongDan_SelectAll";
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

        public DataTable SelectCongDanById(int id)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "CongDan_SelectById";
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

        public DataTable SelectCongDanByName(string name)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "CongDan_SelectByName";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@hoTen", name);


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

        public DataTable SelectCongDanByCmnd(int cmnd)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "CongDan_SelectByCmnd";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@cmnd", cmnd);


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

        public DataTable SelectCongDanByNghenghiep(string nghe)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "CongDan_SelectByNghenghiep";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameter;
                parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@nghe", nghe);


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

        public DataTable SelectCongDanIdNotInHoKhau()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                List<int> listId = new List<int>();
                SqlCommand command = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter;
                command.Connection = connection;
                command.CommandText = "CongDan_SelectIdNotInHoKhau";
                command.CommandType = CommandType.StoredProcedure;

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

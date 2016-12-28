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
                parameter = new SqlParameter[24];
                parameter[0] = new SqlParameter("@idDanToc", dto.IdDantoc);
                parameter[1] = new SqlParameter("@hoTen", dto.HoTen);
                parameter[2] = new SqlParameter("@ngaySinh", dto.HoTen);
                parameter[3] = new SqlParameter("@gioiTinh", dto.GioiTinh);
                parameter[4] = new SqlParameter("@queQuan", dto.Quequan);
                parameter[5] = new SqlParameter("@quocTich", dto.Quoctich);
                parameter[6] = new SqlParameter("@idCDCha", dto.IdCDCha);
                parameter[7] = new SqlParameter("@idCDMe", dto.IdCDMe);
                parameter[8] = new SqlParameter("@noiDangKyKS", dto.NoiDangkyKS);
                parameter[9] = new SqlParameter("@ngayDangKyKS", dto.NgayDangkyKS);
                parameter[10] = new SqlParameter("@idNguoiLamDonKS", dto.NguoiLamDonKS);
                parameter[11] = new SqlParameter("@idCDNguoiKyKS", dto.NguoiKyKS);
                parameter[12] = new SqlParameter("@cmnd", dto.Cmnd);
                parameter[13] = new SqlParameter("@tonGiao", dto.Tongiao);
                parameter[14] = new SqlParameter("@ngheNghiep", dto.Nghenghiep);
                parameter[15] = new SqlParameter("@noiLamViec", dto.NoiLamViec);
                parameter[16] = new SqlParameter("@ngayCapCMND", dto.NgayCapCMND);
                parameter[17] = new SqlParameter("@noiCap", dto.NoiCap);
                parameter[18] = new SqlParameter("@diaChiThuongTru", dto.DiachiThuongtru);
                parameter[19] = new SqlParameter("@trinhDoHocVan", dto.TrinhDoHocVan);
                parameter[20] = new SqlParameter("@trinhDoChuyenMon", dto.TrinhdoChuyenmon);
                parameter[21] = new SqlParameter("@trinhDoNgoaiNgu", dto.TrinhdoNgoaingu);
                parameter[22] = new SqlParameter("@ghiChu", dto.Ghichu);
                parameter[23] = new SqlParameter("@active", dto.Active);

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
                parameter = new SqlParameter[25];
                parameter[0] = new SqlParameter("@idDanToc", dto.Id);
                parameter[1] = new SqlParameter("@idDanToc", dto.IdDantoc);
                parameter[2] = new SqlParameter("@hoTen", dto.HoTen);
                parameter[3] = new SqlParameter("@ngaySinh", dto.HoTen);
                parameter[4] = new SqlParameter("@gioiTinh", dto.GioiTinh);
                parameter[5] = new SqlParameter("@queQuan", dto.Quequan);
                parameter[6] = new SqlParameter("@quocTich", dto.Quoctich);
                parameter[7] = new SqlParameter("@idCDCha", dto.IdCDCha);
                parameter[8] = new SqlParameter("@idCDMe", dto.IdCDMe);
                parameter[9] = new SqlParameter("@noiDangKyKS", dto.NoiDangkyKS);
                parameter[10] = new SqlParameter("@ngayDangKyKS", dto.NgayDangkyKS);
                parameter[11] = new SqlParameter("@idNguoiLamDonKS", dto.NguoiLamDonKS);
                parameter[12] = new SqlParameter("@idCDNguoiKyKS", dto.NguoiKyKS);
                parameter[13] = new SqlParameter("@cmnd", dto.Cmnd);
                parameter[14] = new SqlParameter("@tonGiao", dto.Tongiao);
                parameter[15] = new SqlParameter("@ngheNghiep", dto.Nghenghiep);
                parameter[16] = new SqlParameter("@noiLamViec", dto.NoiLamViec);
                parameter[17] = new SqlParameter("@ngayCapCMND", dto.NgayCapCMND);
                parameter[18] = new SqlParameter("@noiCap", dto.NoiCap);
                parameter[19] = new SqlParameter("@diaChiThuongTru", dto.DiachiThuongtru);
                parameter[20] = new SqlParameter("@trinhDoHocVan", dto.TrinhDoHocVan);
                parameter[21] = new SqlParameter("@trinhDoChuyenMon", dto.TrinhdoChuyenmon);
                parameter[22] = new SqlParameter("@trinhDoNgoaiNgu", dto.TrinhdoNgoaingu);
                parameter[23] = new SqlParameter("@ghiChu", dto.Ghichu);
                parameter[24] = new SqlParameter("@active", dto.Active);

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
    }
}

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
                parameter = new SqlParameter[13];
                parameter[0] = new SqlParameter("@idKhaiSinh", dto.IdKhaiSinh);
                parameter[1] = new SqlParameter("@cmnd", dto.Cmnd);
                parameter[2] = new SqlParameter("@tonGiao", dto.TonGiao);
                parameter[3] = new SqlParameter("@ngheNghiep", dto.NgheNghiep);
                parameter[4] = new SqlParameter("@noiLamViec", dto.NoiLamViec);
                parameter[5] = new SqlParameter("@ngayCapCMND", dto.NgayCapCMND);
                parameter[6] = new SqlParameter("@noiCap", dto.NoiCap);
                parameter[7] = new SqlParameter("@diaChiThuongTru", dto.DiaChiThuongTru);
                parameter[8] = new SqlParameter("@trinhDoHocVan", dto.TrinhDoHocVan);
                parameter[9] = new SqlParameter("@trinhDoChuyenMon", dto.TrinhDoChuyenMon);
                parameter[10] = new SqlParameter("@trinhDoNgoaiNgu", dto.TrinhDoNgoaiNgu);
                parameter[11] = new SqlParameter("@ghiChu", dto.GhiChu);
                parameter[12] = new SqlParameter("@active", dto.Active);


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
                parameter = new SqlParameter[14];
                parameter[0] = new SqlParameter("@id", dto.Id);
                parameter[1] = new SqlParameter("@idKhaiSinh", dto.IdKhaiSinh);
                parameter[2] = new SqlParameter("@cmnd", dto.Cmnd);
                parameter[3] = new SqlParameter("@tonGiao", dto.TonGiao);
                parameter[4] = new SqlParameter("@ngheNghiep", dto.NgheNghiep);
                parameter[5] = new SqlParameter("@noiLamViec", dto.NoiLamViec);
                parameter[6] = new SqlParameter("@ngayCapCMND", dto.NgayCapCMND);
                parameter[7] = new SqlParameter("@noiCap", dto.NoiCap);
                parameter[8] = new SqlParameter("@diaChiThuongTru", dto.DiaChiThuongTru);
                parameter[9] = new SqlParameter("@trinhDoHocVan", dto.TrinhDoHocVan);
                parameter[10] = new SqlParameter("@trinhDoChuyenMon", dto.TrinhDoChuyenMon);
                parameter[11] = new SqlParameter("@trinhDoNgoaiNgu", dto.TrinhDoNgoaiNgu);
                parameter[12] = new SqlParameter("@ghiChu", dto.GhiChu);
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
    }
}

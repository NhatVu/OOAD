using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongDanDTO
    {
        public int Id { get; set; }
        public int IdKhaiSinh { get; set; }
        public int Cmnd { get; set; }
        public string TonGiao { get; set; }
        public string NgheNghiep { get; set; }
        public string NoiLamViec { get; set; }
        public DateTime NgayCapCMND { get; set; }
        public string NoiCap { get; set; }
        public string DiaChiThuongTru { get; set; }
        public string TrinhDoHocVan { get; set; }
        public string TrinhDoChuyenMon { get; set; }
        public string TrinhDoNgoaiNgu { get; set; }

        public CongDanDTO() { }
        public CongDanDTO(int idKhaiSinh, int cmnd, string tonGiao, string ngheNghiep, string noiLamViec, DateTime ngayCapCMND, string noiCap,
            string diaChiThuongTru, string trinhDoHocVan, string trinhDoChuyenMon, string trinhDoNgoaiNgu)
        {
            this.IdKhaiSinh = idKhaiSinh;
            this.Cmnd = cmnd;
            this.TonGiao = tonGiao;
            this.NgheNghiep = ngheNghiep;
            this.NoiLamViec = noiLamViec;
            this.NgayCapCMND = ngayCapCMND;
            this.NoiCap = noiCap;
            this.DiaChiThuongTru = diaChiThuongTru;
            this.TrinhDoHocVan = trinhDoHocVan;
            this.TrinhDoChuyenMon = trinhDoChuyenMon;
            this.TrinhDoNgoaiNgu = trinhDoNgoaiNgu;
        }
    }
}

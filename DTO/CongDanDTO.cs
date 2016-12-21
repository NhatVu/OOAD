using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongDanDTO
    {
        private int Id { get; set; }
        private int IdKhaiSinh { get; set; }
        private int Cmnd { get; set; }
        private string TonGiao { get; set; }
        private string NgheNghiep { get; set; }
        private string NoiLamViec { get; set; }
        private DateTime NgayCapCMND { get; set; }
        private string NoiCap { get; set; }
        private string DiaChiThuongTru { get; set; }
        private string TrinhDoHocVan { get; set; }
        private string TrinhDoChuyenMon { get; set; }
        private string TrinhDoNgoaiNgu { get; set; }

        private string GhiChu { get; set; }
        private int Active { get; set; }

        public CongDanDTO() { }
        public CongDanDTO(int idKhaiSinh, int cmnd, string tonGiao, string ngheNghiep, string noiLamViec, DateTime ngayCapCMND, string noiCap,
                          string diaChiThuongTru, string trinhDoHocVan, string trinhDoChuyenMon, string trinhDoNgoaiNgu, string ghiChu,
                          int active)
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
            this.GhiChu = ghiChu;
            this.Active = active;
        }
    }
}

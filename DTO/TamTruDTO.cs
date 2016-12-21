using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TamTruDTO
    {
        private int Id { get; set; }
        private int IdCongDan { get; set; }
        private int IdTruongCongAn { get; set; }
        private DateTime NgayBatDau { get; set; }
        private DateTime NgayKetThuc { get; set; }
        private string LyDo { get; set; }
        private string DiaChiDen { get; set; }
        private DateTime NgayLamDon { get; set; }

        private string GhiChu { get; set; }
        private int Active { get; set; }

        public TamTruDTO() { }
        public TamTruDTO(int idCongDan, int idTruongCongAn, DateTime ngayBatDau, DateTime ngayKetThuc, string lyDo,
            string diaChiDen, DateTime ngayLamDon, string ghiChu, int active)
        {
            this.IdCongDan = idCongDan;
            this.IdTruongCongAn = idTruongCongAn;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.LyDo = lyDo;
            this.DiaChiDen = diaChiDen;
            this.NgayLamDon = ngayLamDon;
            this.GhiChu = ghiChu;
            this.Active = active;
        }
    }
}

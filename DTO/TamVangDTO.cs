using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class TamVangDTO
    {
        public int Id { get; set; }
        public int IdCongDan { get; set; }
        public int IdTruongCongAn { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string LyDo { get; set; }
        public string DiaChiDen { get; set; }
        public DateTime NgayLamDon { get; set; }

        public TamVangDTO() { }
        public TamVangDTO(int idCongDan, int idTruongCongAn, DateTime ngayBatDau, DateTime ngayKetThuc, string lyDo,
            string diaChiDen, DateTime ngayLamDon)
        {
            this.IdCongDan = idCongDan;
            this.IdTruongCongAn = idTruongCongAn;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.LyDo = lyDo;
            this.DiaChiDen = diaChiDen;
            this.NgayLamDon = ngayLamDon;
        }
    }
}

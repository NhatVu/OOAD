using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuyenKhauDTO
    {
        public int Id { get; set; }
        public int IdCongDan { get; set; }
        public int IdHoKhauCu { get; set; }
        public int IdHoKhauMoi { get; set; }

        public string LyDo { get; set; }

        public int IdVaiTroSoHoKhau { get; set; }
        public string GhiChu { get; set; }
        public int Active { get; set; }

        public ChuyenKhauDTO() { }

        public ChuyenKhauDTO(int idCongDan, int idHoKhauCu, int idHoKhauMoi, string lyDo, int idVaiTroSoHoKhau, string ghiChu, int active)
        {
            this.IdCongDan = idCongDan;
            this.IdHoKhauCu = idHoKhauCu;
            this.IdHoKhauMoi = idHoKhauMoi;
            this.LyDo = lyDo;
            this.IdVaiTroSoHoKhau = idVaiTroSoHoKhau;
            this.GhiChu = ghiChu;
            this.Active = active;
        }
    }
}

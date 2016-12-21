using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuyenKhauDTO
    {
        private int Id { get; set; }
        private int IdCongDan { get; set; }
        private int IdHoKhauCu { get; set; }
        private int IdHoKhauMoi { get; set; }

        private string LyDo { get; set; }

        private int IdVaiTroSoHoKhau { get; set; }
        private string GhiChu { get; set; }
        private int Active { get; set; }

        private ChuyenKhauDTO() { }

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

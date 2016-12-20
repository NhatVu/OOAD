using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoKhauDTO
    {
        public int Id { get; set; }
        public int IdHoKhau { get; set; }
        public int IdCDThanhVien { get; set; }

        public int IDKSThanhVien { get; set; }
        public int IdVaiTroSoHoKhau { get; set; }

        public string GhiChu { get; set; }
        public int Active { get; set; }

        public ChiTietHoKhauDTO() { }

        public ChiTietHoKhauDTO(int idHoKhau, int idCDThanhVien, int idKSThanhVien, int idVaiTroSoHoKhau, string ghiChu, int active)
        {
            this.IdHoKhau = idHoKhau;
            this.IdCDThanhVien = idCDThanhVien;
            this.IdVaiTroSoHoKhau = idVaiTroSoHoKhau;
            this.IDKSThanhVien = idKSThanhVien;
            this.GhiChu = ghiChu;
            this.Active = active;
        }
    }
}

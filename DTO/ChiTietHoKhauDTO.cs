using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoKhauDTO
    {
        private int Id { get; set; }
        private int IdHoKhau { get; set; }
        private int IdCDThanhVien { get; set; }

        private int IDKSThanhVien { get; set; }
        private int IdVaiTroSoHoKhau { get; set; }

        private string GhiChu { get; set; }
        private int Active { get; set; }

        private ChiTietHoKhauDTO() { }

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

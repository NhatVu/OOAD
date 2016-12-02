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
        public int IdThanhVien { get; set; }
        public int IdVaiTroSoHoKhau { get; set; }

        public ChiTietHoKhauDTO() { }

        public ChiTietHoKhauDTO(int idHoKhau, int idThanhVien, int idVaiTroSoHoKhau)
        {
            this.IdHoKhau = idHoKhau;
            this.IdThanhVien = idThanhVien;
            this.IdVaiTroSoHoKhau = idVaiTroSoHoKhau;
        }
    }
}

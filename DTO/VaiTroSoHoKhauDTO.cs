using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VaiTroSoHoKhauDTO
    {
        public int Id { get; set; }
        public string TenVaiTro { get; set; }
        public string GhiChu { get; set; }
        public int Active { get; set; }
        public VaiTroSoHoKhauDTO() { }
        public VaiTroSoHoKhauDTO(string tenVaiTro, string ghiChu, int active)
        {
            this.TenVaiTro = tenVaiTro;
            this.GhiChu = ghiChu;
            this.Active = active;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VaiTroSoHoKhauDTO
    {
        private int Id { get; set; }
        private string TenVaiTro { get; set; }
        private string GhiChu { get; set; }
        private int Active { get; set; }
        private VaiTroSoHoKhauDTO() { }
        public VaiTroSoHoKhauDTO(string tenVaiTro, string ghiChu, int active)
        {
            this.TenVaiTro = tenVaiTro;
            this.GhiChu = ghiChu;
            this.Active = active;
        }
    }
}

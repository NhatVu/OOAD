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
        public VaiTroSoHoKhauDTO() { }
        public VaiTroSoHoKhauDTO(string tenVaiTro)
        {
            this.TenVaiTro = tenVaiTro;
        }
    }
}

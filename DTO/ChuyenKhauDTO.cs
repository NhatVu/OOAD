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

        public ChuyenKhauDTO() { }

        public ChuyenKhauDTO(int idCongDan, int idHoKhauCu, int idHoKhauMoi)
        {
            this.IdCongDan = idCongDan;
            this.IdHoKhauCu = idHoKhauCu;
            this.IdHoKhauMoi = idHoKhauMoi;
        }
    }
}

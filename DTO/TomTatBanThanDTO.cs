using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class TomTatBanThanDTO
    {
        public int Id { get; set; }
        public int IdCongDan { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string ChoO { get; set; } /*choox owr*/
        public string NgheNghiep { get; set; }

        public TomTatBanThanDTO() { }

        public TomTatBanThanDTO(int idCongDan, DateTime ngayBatDau, DateTime ngayKetThuc, string choO, string ngheNghiep)
        {
            this.IdCongDan = idCongDan;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.ChoO = choO;
            this.NgheNghiep = ngheNghiep;
        }
    }
}

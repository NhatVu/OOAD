using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TomTatBanThanDTO
    {
        private int Id { get; set; }
        private int IdCongDan { get; set; }
        private DateTime NgayBatDau { get; set; }
        private DateTime NgayKetThuc { get; set; }
        private string ChoO { get; set; } /*choox owr*/
        private string NgheNghiep { get; set; }
        private string GhiChu { get; set; }
        private int Active { get; set; }
        public TomTatBanThanDTO() { }

        public TomTatBanThanDTO(int idCongDan, DateTime ngayBatDau, DateTime ngayKetThuc, string choO, string ngheNghiep, string ghiChu, int active)
        {
            this.IdCongDan = idCongDan;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.ChoO = choO;
            this.NgheNghiep = ngheNghiep;
            this.GhiChu = ghiChu;
            this.Active = active;
        }
    }
}

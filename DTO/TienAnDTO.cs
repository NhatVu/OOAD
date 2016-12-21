using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TienAnDTO
    {
        private int Id { get; set; }
        private int IdCongDan { get; set; }
        private string ToiDanh { get; set; }
        private string HinhPhat { get; set; }
        private DateTime NgayThang { get; set; }
        private string NoiTuyenAn { get; set; }
        private string GhiChu { get; set; }
        private int Active { get; set; }
        private TienAnDTO() { }
        public TienAnDTO(int idCongDan, string toiDanh, string hinhPhat, DateTime ngayThang, string noiTuyenAn, string ghiChu, int active)
        {
            this.IdCongDan = idCongDan;
            this.ToiDanh = toiDanh;
            this.HinhPhat = hinhPhat;
            this.NgayThang = ngayThang;
            this.NoiTuyenAn = noiTuyenAn;
            this.GhiChu = ghiChu;
            this.Active = active;
        }
    }
}

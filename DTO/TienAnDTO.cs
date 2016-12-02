using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TienAnDTO
    {
        public int Id { get; set; }
        public int IdCongDan { get; set; }
        public string ToiDanh { get; set; }
        public string HinhPhat { get; set; }
        public DateTime NgayThang { get; set; }
        public string NoiTuyenAn { get; set; }
        public TienAnDTO() { }
        public TienAnDTO(int idCongDan, string toiDanh, string hinhPhat, DateTime ngayThang, string noiTuyenAn)
        {
            this.IdCongDan = idCongDan;
            this.ToiDanh = toiDanh;
            this.HinhPhat = hinhPhat;
            this.NgayThang = ngayThang;
            this.NoiTuyenAn = noiTuyenAn;
        }
    }
}

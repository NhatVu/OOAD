using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoKhauDTO
    {
        public int Id { get; set; }
        public int IdCDTruongCongAn { get; set; }
        public string NoiCap { get; set; }
        public string NoiDangKyThuongTru { get; set; }
        public string GhiChu { get; set; }
        public int Active { get; set; }
        // 
        public HoKhauDTO(string noiCap, int idCDTruongCongAn, string noiDangKyThuongTru,string ghiChu, int active)
        {
            this.NoiCap = noiCap;
            this.IdCDTruongCongAn = idCDTruongCongAn;
            this.NoiDangKyThuongTru = noiDangKyThuongTru;
            this.GhiChu = ghiChu;
            this.Active = active;
        }
    }
}

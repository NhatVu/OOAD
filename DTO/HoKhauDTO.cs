using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoKhauDTO
    {
        private int Id { get; set; }
        private int IdCDTruongCongAn { get; set; }
        private string NoiCap { get; set; }
        private string NoiDangKyThuongTru { get; set; }
        private string GhiChu { get; set; }
        private int Active { get; set; }
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

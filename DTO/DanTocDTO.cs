using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanTocDTO
    {
        public int Id { get; set; }
        public string TenDanToc { get; set; }
        public string GhiChu { get; set; }
        public int Active { get; set; }

        public DanTocDTO() { }
        public DanTocDTO(string tenDanToc, string ghiChu, int active)
        {
            this.TenDanToc = tenDanToc;
            this.GhiChu = ghiChu;
            this.Active = active;
        }
    }
}

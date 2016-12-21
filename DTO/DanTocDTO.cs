using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanTocDTO
    {
        private int Id { get; set; }
        private string TenDanToc { get; set; }
        private string GhiChu { get; set; }
        private int Active { get; set; }

        public DanTocDTO() { }
        public DanTocDTO(string tenDanToc, string ghiChu, int active)
        {
            this.TenDanToc = tenDanToc;
            this.GhiChu = ghiChu;
            this.Active = active;
        }
    }
}

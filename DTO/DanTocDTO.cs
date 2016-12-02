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

        public DanTocDTO() { }
        public DanTocDTO(string tenDanToc)
        {
            this.TenDanToc = tenDanToc;
        }
    }
}

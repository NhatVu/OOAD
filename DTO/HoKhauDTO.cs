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
        public int IdChuHo { get; set; }

        public HoKhauDTO(int idChuHo)
        {
            this.IdChuHo = idChuHo;
        }
    }
}

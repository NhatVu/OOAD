using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAcessLayer;

namespace BusinessLogicLayer
{
    public class HoKhauBUS
    {
        HoKhauDAO obj = new HoKhauDAO();
        public bool insertHoKhau(HoKhauDTO dto)
        {
            return obj.insertHoKhau(dto);
        }

        public bool updateHoKhau(HoKhauDTO dto)
        {
            return obj.updateHoKhau(dto);
        }

        public bool deleteHoKhau(int id)
        {
            return obj.deleteHoKhau(id);
        }
    }
}

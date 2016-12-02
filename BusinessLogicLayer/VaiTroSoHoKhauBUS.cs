using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAcessLayer;

namespace BusinessLogicLayer
{
    public class VaiTroSoHoKhauBUS
    {
        VaiTroSoHoKhauDAO obj = new VaiTroSoHoKhauDAO();
        public bool insertVaiTroSoHoKhau(VaiTroSoHoKhauDTO dto)
        {
            return obj.insertVaiTroSoHoKhau(dto);
        }

        public bool updateVaiTroSoHoKhau(VaiTroSoHoKhauDTO dto)
        {
            return obj.updateVaiTroSoHoKhau(dto);
        }

        public bool deleteVaiTroSoHoKhau(int id)
        {
            return obj.deleteVaiTroSoHoKhau(id);
        }
    }
}

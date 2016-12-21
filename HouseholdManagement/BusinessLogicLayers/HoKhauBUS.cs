using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAcessLayer;
using System.Data;

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
        public DataTable SelectAllHoKhau()
        {
            return obj.SelectAllHoKhau();
        }
        public DataTable SelectHoKhauById(int id)
        {
            return obj.SelectHoKhauById(id);
        }
    }
}

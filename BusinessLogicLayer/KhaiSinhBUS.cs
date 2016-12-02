using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAcessLayer;

namespace BusinessLogicLayer
{
    public class KhaiSinhBUS
    {
        KhaiSinhDAO obj = new KhaiSinhDAO();
        public bool insertKhaiSinh(KhaiSinhDTO dto)
        {
            return obj.insertKhaiSinh(dto);
        }

        public bool updateKhaiSinh(KhaiSinhDTO dto)
        {
            return obj.updateKhaiSinh(dto);
        }

        public bool deleteKhaiSinh(int id)
        {
            return obj.deleteKhaiSinh(id);
        }
    }
}

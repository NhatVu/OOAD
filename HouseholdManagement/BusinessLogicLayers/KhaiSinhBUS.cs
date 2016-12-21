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

        public DataTable SelectAllKhaiSinh()
        {
            return obj.SelectAllKhaiSinh();
        }
        public DataTable SelectKhaiSinhById(int id)
        {
            return obj.SelectKhaiSinhById(id);
        }
    }
}

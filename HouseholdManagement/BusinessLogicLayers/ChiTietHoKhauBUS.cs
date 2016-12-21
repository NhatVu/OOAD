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
    public class ChiTietHoKhauBUS
    {
        ChiTietHoKhauDAO obj = new ChiTietHoKhauDAO();
        public bool insertChiTietHoKhau(ChiTietHoKhauDTO dto)
        {
            return obj.insertChiTietHoKhau(dto);
        }

        public bool updateChiTietHoKhau(ChiTietHoKhauDTO dto)
        {
            return obj.updateChiTietHoKhau(dto);
        }

        public bool deleteChiTietHoKhau(int id)
        {
            return obj.deleteChiTietHoKhau(id);
        }

        public DataTable SelectAllChiTietHoKhau()
        {
            return obj.SelectAllChiTietHoKhau();
        }
        public DataTable SelectChiTietHoKhauById(int id)
        {
            return obj.SelectChiTietHoKhauById(id);
        }


    }
}

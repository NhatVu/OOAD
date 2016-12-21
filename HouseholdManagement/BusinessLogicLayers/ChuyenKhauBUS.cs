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
    public class ChuyenKhauBUS
    {
        ChuyenKhauDAO obj = new ChuyenKhauDAO();
        public bool insertChuyenKhau(ChuyenKhauDTO dto)
        {
            return obj.insertChuyenKhau(dto);
        }

        public bool updateChuyenKhau(ChuyenKhauDTO dto)
        {
            return obj.updateChuyenKhau(dto);
        }

        public bool deleteChuyenKhau(int id)
        {
            return obj.deleteChuyenKhau(id);
        }

        public DataTable SelectAllChuyenKhau()
        {
            return obj.SelectAllChuyenKhau();
        }
        public DataTable SelectChuyenKhauById(int id)
        {
            return obj.SelectChuyenKhauById(id);
        }
    }
}

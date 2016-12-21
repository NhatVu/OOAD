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
    public class TamVangBUS
    {
        TamVangDAO obj = new TamVangDAO();
        public bool insertTamVang(TamVangDTO dto)
        {
            return obj.insertTamVang(dto);
        }

        public bool updateTamVang(TamVangDTO dto)
        {
            return obj.updateTamVang(dto);
        }

        public bool deleteTamVang(int id)
        {
            return obj.deleteTamVang(id);
        }

        public DataTable SelectAllTamVang()
        {
            return obj.SelectAllTamVang();
        }
        public DataTable SelectTamVangById(int id)
        {
            return obj.SelectTamVangById(id);
        }
    }
}

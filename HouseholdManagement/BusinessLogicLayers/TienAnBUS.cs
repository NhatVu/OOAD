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
    public class TienAnBUS
    {
        TienAnDAO obj = new TienAnDAO();
        public bool insertTienAn(TienAnDTO dto)
        {
            return obj.insertTienAn(dto);
        }

        public bool updateTienAn(TienAnDTO dto)
        {
            return obj.updateTienAn(dto);
        }

        public bool deleteTienAn(int id)
        {
            return obj.deleteTienAn(id);
        }

        public DataTable SelectAllTienAn()
        {
            return obj.SelectAllTienAn();
        }
        public DataTable SelectTienAnById(int id)
        {
            return obj.SelectTienAnById(id);
        }
    }
}

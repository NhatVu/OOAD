using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAcessLayer;

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
    }
}

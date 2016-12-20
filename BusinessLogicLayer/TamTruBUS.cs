using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAcessLayer;

namespace BusinessLogicLayer
{
    public class TamTruBUS
    {
        TamTruDAO obj = new TamTruDAO();
        public bool insertTamTru(TamTruDTO dto)
        {
            return obj.insertTamTru(dto);
        }

        public bool updateTamTru(TamTruDTO dto)
        {
            return obj.updateTamTru(dto);
        }

        public bool deleteTamTru(int id)
        {
            return obj.deleteTamTru(id);
        }
    }
}

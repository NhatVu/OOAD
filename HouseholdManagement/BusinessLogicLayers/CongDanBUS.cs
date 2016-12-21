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
    public class CongDanBUS
    {
        CongDanDAO obj = new CongDanDAO();
        public bool insertCongDan(CongDanDTO dto)
        {
            return obj.insertCongDan(dto);
        }

        public bool updateCongDan(CongDanDTO dto)
        {
            return obj.updateCongDan(dto);
        }

        public bool deleteCongDan(int id)
        {
            return obj.deleteCongDan(id);
        }

        public DataTable SelectAllCongDan()
        {
            return obj.SelectAllCongDan();
        }
        public DataTable SelectCongDanById(int id)
        {
            return obj.SelectCongDanById(id);
        }
    }
}

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
    public class TomTatBanThanBUS
    {
        TomTatBanThanDAO obj = new TomTatBanThanDAO();
        public bool insertTomTatBanThan(TomTatBanThanDTO dto)
        {
            return obj.insertTomTatBanThan(dto);
        }

        public bool updateTomTatBanThan(TomTatBanThanDTO dto)
        {
            return obj.updateTomTatBanThan(dto);
        }

        public bool deleteTomTatBanThan(int id)
        {
            return obj.deleteTomTatBanThan(id);
        }

        public DataTable SelectAllTomTatBanThan()
        {
            return obj.SelectAllTomTatBanThan();
        }
        public DataTable SelectTomTatBanThanById(int id)
        {
            return obj.SelectTomTatBanThanById(id);
        }
    }
}

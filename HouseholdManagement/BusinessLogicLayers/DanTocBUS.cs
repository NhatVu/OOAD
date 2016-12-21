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
    public class DanTocBUS
    {
        DanTocDAO obj = new DanTocDAO();
        public bool insertDanToc(DanTocDTO dto)
        {
            return obj.insertDanToc(dto);
        }

        public bool updateDanToc(DanTocDTO dto)
        {
            return obj.updateDanToc(dto);
        }

        public bool deleteDanToc(int id)
        {
            return obj.deleteDanToc(id);
        }

        public DataTable SelectAllDanToc()
        {
            return obj.SelectAllDanToc();
        }
        public DataTable SelectDanTocById(int id)
        {
            return obj.SelectDanTocById(id);
        }
    }
}

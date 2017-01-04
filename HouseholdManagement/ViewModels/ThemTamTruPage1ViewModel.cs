using DataAcessLayer;
using DTO;
using HouseholdManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdManagement.ViewModels
{
    class ThemTamTruPage1ViewModel
    {
        private CongDanDTO mCongDan;
        private readonly List<int> listIdCongDan = new List<int>();
        private readonly List<string> listTenCongDan = new List<string>();
        private readonly List<int> listCmndCongDan = new List<int>();



        public ThemTamTruPage1ViewModel(CongAnDTO congan)
        {
            List<CongDanDTO> listCongDan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectCongDanById(congan.Id));

            if (listCongDan.Count > 0)
            {
                mCongDan = listCongDan[0];
            }

            List<CongDanDTO> allCongdan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectAllCongDan());
            if (allCongdan.Count > 0)
            {
                foreach (CongDanDTO cd in allCongdan)
                {
                    listIdCongDan.Add(cd.Id);
                    if (cd.Cmnd != 0) listCmndCongDan.Add(cd.Cmnd);
                    listTenCongDan.Add(cd.HoTen);
                }
            }
        }

        public string TenCongAn
        {
            get
            {
                return mCongDan.HoTen;
            }
        }

        public DateTime NgayLamDon
        {
            get
            {
                return DateTime.Now;
            }
        }

        public List<int> ListIdCongDan
        {
            get
            {
                return listIdCongDan;
            }
        }

        public List<string> ListTenCongDan
        {
            get
            {
                return listTenCongDan;
            }
        }

        public List<int> ListCmndCongDan
        {
            get
            {
                return listCmndCongDan;
            }
        }
    }
}

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
    class ThemTamVangPage1ViewModel
    {
        private CongDanDTO mCongDan;
        public ThemTamVangPage1ViewModel(CongAnDTO congan)
        {
            List<CongDanDTO> listCongDan = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectCongDanById(congan.Id));
            if (listCongDan.Count > 0)
            {
                mCongDan = listCongDan[0];
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
    }
}
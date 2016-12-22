using DataAcessLayer;
using DTO;
using HouseholdManagement.Models;
using HouseholdManagement.UserControls;
using HouseholdManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HouseholdManagement
{
    class QuanlyHokhauViewModel
    {
        private readonly static String NGHENGHIEP_COLUMN = "Trưởng Công An";

        public QuanlyHokhauViewModel()
        {
            mHoKhauList = Constant.DataTableToList<HoKhauDTO>(new HoKhauDAO().SelectAllHoKhau());
            mCongDanList = Constant.DataTableToList<CongDanDTO>(new CongDanDAO().SelectAllCongDan());
            mKhaiSinhList = Constant.DataTableToList<KhaiSinhDTO>(new KhaiSinhDAO().SelectAllKhaiSinh());
            mCongAnList = new List<KhaiSinhDTO>();
            foreach(CongDanDTO cd in mCongDanList)
            {
                if(cd.Nghenghiep == NGHENGHIEP_COLUMN)
                {
                    mCongAnList.Add(mKhaiSinhList.Find(x => x.Id == cd.IdKhaisinh));
                }
            }
        }
        private List<HoKhauDTO> mHoKhauList;
        private List<CongDanDTO> mCongDanList;
        private List<KhaiSinhDTO> mCongAnList;
        private List<KhaiSinhDTO> mKhaiSinhList;

        public List<HoKhauDTO> HoKhauList
        {
            get
            {
                return mHoKhauList;
            }

            set
            {
                mHoKhauList = value;
            }
        }

        public List<CongDanDTO> CongDanList
        {
            get
            {
                return mCongDanList;
            }

            set
            {
                mCongDanList = value;
            }
        }

        public List<KhaiSinhDTO> CongAnList
        {
            get
            {
                return mCongAnList;
            }

            set
            {
                mCongAnList = value;
            }
        }

        public List<KhaiSinhDTO> KhaiSinhList
        {
            get
            {
                return mKhaiSinhList;
            }

            set
            {
                mKhaiSinhList = value;
            }
        }
    }
}

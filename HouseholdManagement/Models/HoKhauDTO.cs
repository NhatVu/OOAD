using DataAcessLayer;
using HouseholdManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoKhauDTO
    {
        private int mId;
        private int mIdCDTruongCongAn;
        private string mNoiCap;
        private DateTime mNgayCap;
        private string mNoiDangKyThuongTru;
        private string mGhiChu;
        private int mActive;

        public int IdCDTruongCongAn
        {
            get
            {
                return mIdCDTruongCongAn;
            }

            set
            {
                mIdCDTruongCongAn = value;
            }
        }

        public string NoiCap
        {
            get
            {
                return mNoiCap;
            }

            set
            {
                mNoiCap = value;
            }
        }

        public DateTime NgayCap
        {
            get
            {
                return mNgayCap;
            }

            set
            {
                mNgayCap = value;
            }
        }

        public string NoiDangKyThuongTru
        {
            get
            {
                return mNoiDangKyThuongTru;
            }

            set
            {
                mNoiDangKyThuongTru = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return mGhiChu;
            }

            set
            {
                mGhiChu = value;
            }
        }

        public int Active
        {
            get
            {
                return mActive;
            }

            set
            {
                mActive = value;
            }
        }

        public int Id
        {
            get
            {
                return mId;
            }

            set
            {
                mId = value;
            }
        }


        public HoKhauDTO()
        {

        }

        public HoKhauDTO(int mIdCDTruongCongAn, string mNoiCap, DateTime mNgayCap, string mNoiDangKyThuongTru, string mGhiChu, int mActive)
        {
            this.mIdCDTruongCongAn = mIdCDTruongCongAn;
            this.mNoiCap = mNoiCap;
            this.mNgayCap = mNgayCap;
            this.mNoiDangKyThuongTru = mNoiDangKyThuongTru;
            this.mGhiChu = mGhiChu;
            this.mActive = mActive;
        }
    }
}

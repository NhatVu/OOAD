using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongDanDTO
    {
        private int mId;
        private int mIdKhaisinh;
        private int mCmnd;
        private string mTongiao;
        private string mNghenghiep;
        private string mNoiLamviec;
        private DateTime mNgayCapCMND;
        private string mNoiCap;
        private string mDiachiThuongtru;
        private string mTrinhdoHocvan;
        private string mTrinhdoChuyenmon;
        private string mTrinhdoNgoaingu;
        private string mGhichu;
        private int mActive;

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

        public int IdKhaisinh
        {
            get
            {
                return mIdKhaisinh;
            }

            set
            {
                mIdKhaisinh = value;
            }
        }

        public int Cmnd
        {
            get
            {
                return mCmnd;
            }

            set
            {
                mCmnd = value;
            }
        }

        public string Tongiao
        {
            get
            {
                return mTongiao;
            }

            set
            {
                mTongiao = value;
            }
        }

        public string Nghenghiep
        {
            get
            {
                return mNghenghiep;
            }

            set
            {
                mNghenghiep = value;
            }
        }

        public string NoiLamviec
        {
            get
            {
                return mNoiLamviec;
            }

            set
            {
                mNoiLamviec = value;
            }
        }

        public DateTime NgayCapCMND
        {
            get
            {
                return mNgayCapCMND;
            }

            set
            {
                mNgayCapCMND = value;
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

        public string DiachiThuongtru
        {
            get
            {
                return mDiachiThuongtru;
            }

            set
            {
                mDiachiThuongtru = value;
            }
        }

        public string TrinhdoHocvan
        {
            get
            {
                return mTrinhdoHocvan;
            }

            set
            {
                mTrinhdoHocvan = value;
            }
        }

        public string TrinhdoChuyenmon
        {
            get
            {
                return mTrinhdoChuyenmon;
            }

            set
            {
                mTrinhdoChuyenmon = value;
            }
        }

        public string TrinhdoNgoaingu
        {
            get
            {
                return mTrinhdoNgoaingu;
            }

            set
            {
                mTrinhdoNgoaingu = value;
            }
        }

        public string Ghichu
        {
            get
            {
                return mGhichu;
            }

            set
            {
                mGhichu = value;
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

        public CongDanDTO() { }

        public CongDanDTO(int mIdKhaisinh, int mCmnd, string mTongiao, string mNghenghiep, string mNoiLamviec, DateTime mNgayCapCMND, string mNoiCap, string mDiachiThuongtru, string mTrinhdoHocvan, string mTrinhdoChuyenmon, string mTrinhdoNgoaingu, string mGhichu, int mActive)
        {
            this.mIdKhaisinh = mIdKhaisinh;
            this.mCmnd = mCmnd;
            this.mTongiao = mTongiao;
            this.mNghenghiep = mNghenghiep;
            this.mNoiLamviec = mNoiLamviec;
            this.mNgayCapCMND = mNgayCapCMND;
            this.mNoiCap = mNoiCap;
            this.mDiachiThuongtru = mDiachiThuongtru;
            this.mTrinhdoHocvan = mTrinhdoHocvan;
            this.mTrinhdoChuyenmon = mTrinhdoChuyenmon;
            this.mTrinhdoNgoaingu = mTrinhdoNgoaingu;
            this.mGhichu = mGhichu;
            this.mActive = mActive;
        }
    }
}

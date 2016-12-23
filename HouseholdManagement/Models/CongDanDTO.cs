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
        private int mIdDantoc;
        private string mHoTen;
        private DateTime mNgaySinh;
        private int mGioiTinh;
        private string mQuequan;
        private string mQuoctich;
        private int mIdCDCha;
        private int mIdCDMe;
        private string mNoiDangkyKS;
        private DateTime mNgayDangkyKS;
        private int mNguoiLamDonKS;
        private int mNguoiKyKS;
        private int mCmnd;
        private string mTongiao;
        private string mNghenghiep;
        private string mNoiLamViec;
        private DateTime mNgayCapCMND;
        private string mNoiCap;
        private string mDiachiThuongtru;
        private string mTrinhDoHocVan;
        private string mTrinhdoChuyenmon;
        private string mTrinhdoNgoaingu;
        private string mGhichu;
        private int mActive;

        public CongDanDTO()
        {
                
        }

        public CongDanDTO(int mIdDantoc, string mHoTen, DateTime mNgaySinh, int mGioiTinh, string mQuequan, string mQuoctich, int mIdCDCha, int mIdCDMe, string mNoiDangkyKS, DateTime mNgayDangkyKS, int mNguoiLamDonKS, int mNguoiKyKS, int mCmnd, string mTongiao, string mNghenghiep, string mNoiLamViec, DateTime mNgayCapCMND, string mNoiCap, string mDiachiThuongtru, string mTrinhDoHocVan, string mTrinhdoChuyenmon, string mTrinhdoNgoaingu, string mGhichu, int mActive)
        {
            this.mIdDantoc = mIdDantoc;
            this.mHoTen = mHoTen;
            this.mNgaySinh = mNgaySinh;
            this.mGioiTinh = mGioiTinh;
            this.mQuequan = mQuequan;
            this.mQuoctich = mQuoctich;
            this.mIdCDCha = mIdCDCha;
            this.mIdCDMe = mIdCDMe;
            this.mNoiDangkyKS = mNoiDangkyKS;
            this.mNgayDangkyKS = mNgayDangkyKS;
            this.mNguoiLamDonKS = mNguoiLamDonKS;
            this.mNguoiKyKS = mNguoiKyKS;
            this.mCmnd = mCmnd;
            this.mTongiao = mTongiao;
            this.mNghenghiep = mNghenghiep;
            this.mNoiLamViec = mNoiLamViec;
            this.mNgayCapCMND = mNgayCapCMND;
            this.mNoiCap = mNoiCap;
            this.mDiachiThuongtru = mDiachiThuongtru;
            this.mTrinhDoHocVan = mTrinhDoHocVan;
            this.mTrinhdoChuyenmon = mTrinhdoChuyenmon;
            this.mTrinhdoNgoaingu = mTrinhdoNgoaingu;
            this.mGhichu = mGhichu;
            this.mActive = mActive;
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

        public int IdDantoc
        {
            get
            {
                return mIdDantoc;
            }

            set
            {
                mIdDantoc = value;
            }
        }

        public string HoTen
        {
            get
            {
                return mHoTen;
            }

            set
            {
                mHoTen = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return mNgaySinh;
            }

            set
            {
                mNgaySinh = value;
            }
        }

        public int GioiTinh
        {
            get
            {
                return mGioiTinh;
            }

            set
            {
                mGioiTinh = value;
            }
        }

        public string Quequan
        {
            get
            {
                return mQuequan;
            }

            set
            {
                mQuequan = value;
            }
        }

        public string Quoctich
        {
            get
            {
                return mQuoctich;
            }

            set
            {
                mQuoctich = value;
            }
        }

        public int IdCDCha
        {
            get
            {
                return mIdCDCha;
            }

            set
            {
                mIdCDCha = value;
            }
        }

        public int IdCDMe
        {
            get
            {
                return mIdCDMe;
            }

            set
            {
                mIdCDMe = value;
            }
        }

        public string NoiDangkyKS
        {
            get
            {
                return mNoiDangkyKS;
            }

            set
            {
                mNoiDangkyKS = value;
            }
        }

        public DateTime NgayDangkyKS
        {
            get
            {
                return mNgayDangkyKS;
            }

            set
            {
                mNgayDangkyKS = value;
            }
        }

        public int NguoiLamDonKS
        {
            get
            {
                return mNguoiLamDonKS;
            }

            set
            {
                mNguoiLamDonKS = value;
            }
        }

        public int NguoiKyKS
        {
            get
            {
                return mNguoiKyKS;
            }

            set
            {
                mNguoiKyKS = value;
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

        public string NoiLamViec
        {
            get
            {
                return mNoiLamViec;
            }

            set
            {
                mNoiLamViec = value;
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

        public string TrinhDoHocVan
        {
            get
            {
                return mTrinhDoHocVan;
            }

            set
            {
                mTrinhDoHocVan = value;
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
    }
}

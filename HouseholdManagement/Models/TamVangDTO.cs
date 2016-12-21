using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TamVangDTO
    {
        private int mId;
        private int mIdCongdan;
        private int mIdTruongCongAn;
        private DateTime mNgayBatDau;
        private DateTime mNgayKetThuc;
        private string mLyDo;
        private string mDiaChiDen;
        private DateTime mNgayLamDon;
        private string mGhiChu;
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

        public int IdCongdan
        {
            get
            {
                return mIdCongdan;
            }

            set
            {
                mIdCongdan = value;
            }
        }

        public int IdTruongCongAn
        {
            get
            {
                return mIdTruongCongAn;
            }

            set
            {
                mIdTruongCongAn = value;
            }
        }

        public DateTime NgayBatDau
        {
            get
            {
                return mNgayBatDau;
            }

            set
            {
                mNgayBatDau = value;
            }
        }

        public DateTime NgayKetThuc
        {
            get
            {
                return mNgayKetThuc;
            }

            set
            {
                mNgayKetThuc = value;
            }
        }

        public string LyDo
        {
            get
            {
                return mLyDo;
            }

            set
            {
                mLyDo = value;
            }
        }

        public string DiaChiDen
        {
            get
            {
                return mDiaChiDen;
            }

            set
            {
                mDiaChiDen = value;
            }
        }

        public DateTime NgayLamDon
        {
            get
            {
                return mNgayLamDon;
            }

            set
            {
                mNgayLamDon = value;
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

        public TamVangDTO() { }

        public TamVangDTO(int mIdCongdan, int mIdTruongCongAn, DateTime mNgayBatDau, DateTime mNgayKetThuc, string mLyDo, string mDiaChiDen, DateTime mNgayLamDon, string mGhiChu, int mActive)
        {
            this.mIdCongdan = mIdCongdan;
            this.mIdTruongCongAn = mIdTruongCongAn;
            this.mNgayBatDau = mNgayBatDau;
            this.mNgayKetThuc = mNgayKetThuc;
            this.mLyDo = mLyDo;
            this.mDiaChiDen = mDiaChiDen;
            this.mNgayLamDon = mNgayLamDon;
            this.mGhiChu = mGhiChu;
            this.mActive = mActive;
        }
    }
}

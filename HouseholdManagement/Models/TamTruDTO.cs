using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TamTruDTO
    {
        private int mId;
        private int mIdCongdan;
        private int mIdTruongCongan;
        private DateTime mNgayBatdau;
        private DateTime mNgayKetthuc;
        private string mLydo;
        private string mDiachiDen;
        private DateTime mNgayLamDon;
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

        public int IdTruongCongan
        {
            get
            {
                return mIdTruongCongan;
            }

            set
            {
                mIdTruongCongan = value;
            }
        }

        public DateTime NgayBatdau
        {
            get
            {
                return mNgayBatdau;
            }

            set
            {
                mNgayBatdau = value;
            }
        }

        public DateTime NgayKetthuc
        {
            get
            {
                return mNgayKetthuc;
            }

            set
            {
                mNgayKetthuc = value;
            }
        }

        public string Lydo
        {
            get
            {
                return mLydo;
            }

            set
            {
                mLydo = value;
            }
        }

        public string DiachiDen
        {
            get
            {
                return mDiachiDen;
            }

            set
            {
                mDiachiDen = value;
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

        public TamTruDTO() { }

        public TamTruDTO(int mIdCongdan, int mIdTruongCongan, DateTime mNgayBatdau, DateTime mNgayKetthuc, string mLydo, string mDiachiDen, DateTime mNgayLamDon, string mGhichu, int mActive)
        {
            this.mIdCongdan = mIdCongdan;
            this.mIdTruongCongan = mIdTruongCongan;
            this.mNgayBatdau = mNgayBatdau;
            this.mNgayKetthuc = mNgayKetthuc;
            this.mLydo = mLydo;
            this.mDiachiDen = mDiachiDen;
            this.mNgayLamDon = mNgayLamDon;
            this.mGhichu = mGhichu;
            this.mActive = mActive;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TienAnDTO
    {
        private int mId;
        private int mIdCongdan;
        private string mToidanh;
        private string mHinhphat;
        private DateTime mNgayThang;
        private string mNoiTuyenAn;
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

        public string Toidanh
        {
            get
            {
                return mToidanh;
            }

            set
            {
                mToidanh = value;
            }
        }

        public string Hinhphat
        {
            get
            {
                return mHinhphat;
            }

            set
            {
                mHinhphat = value;
            }
        }

        public DateTime NgayThang
        {
            get
            {
                return mNgayThang;
            }

            set
            {
                mNgayThang = value;
            }
        }

        public string NoiTuyenAn
        {
            get
            {
                return mNoiTuyenAn;
            }

            set
            {
                mNoiTuyenAn = value;
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

        private TienAnDTO() { }

        public TienAnDTO(int mIdCongdan, string mToidanh, string mHinhphat, DateTime mNgayThang, string mNoiTuyenAn, string mGhichu, int mActive)
        {
            this.mIdCongdan = mIdCongdan;
            this.mToidanh = mToidanh;
            this.mHinhphat = mHinhphat;
            this.mNgayThang = mNgayThang;
            this.mNoiTuyenAn = mNoiTuyenAn;
            this.mGhichu = mGhichu;
            this.mActive = mActive;
        }
    }
}

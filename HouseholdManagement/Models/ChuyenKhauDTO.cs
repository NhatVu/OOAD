using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuyenKhauDTO
    {
        private int mId;
        private int mIdCongdan;
        private int mIdHokhauCu;
        private int mIdHokhauMoi;
        private string mLyDo;
        private int mIdVaitroSoHokhau;
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

        public int IdHokhauCu
        {
            get
            {
                return mIdHokhauCu;
            }

            set
            {
                mIdHokhauCu = value;
            }
        }

        public int IdHokhauMoi
        {
            get
            {
                return mIdHokhauMoi;
            }

            set
            {
                mIdHokhauMoi = value;
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

        public int IdVaitroSoHokhau
        {
            get
            {
                return mIdVaitroSoHokhau;
            }

            set
            {
                mIdVaitroSoHokhau = value;
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

        private ChuyenKhauDTO() { }

        public ChuyenKhauDTO(int mIdCongdan, int mIdHokhauCu, int mIdHokhauMoi, string mLyDo, int mIdVaitroSoHokhau, string mGhichu, int mActive)
        {
            this.mIdCongdan = mIdCongdan;
            this.mIdHokhauCu = mIdHokhauCu;
            this.mIdHokhauMoi = mIdHokhauMoi;
            this.mLyDo = mLyDo;
            this.mIdVaitroSoHokhau = mIdVaitroSoHokhau;
            this.mGhichu = mGhichu;
            this.mActive = mActive;
        }
    }
}

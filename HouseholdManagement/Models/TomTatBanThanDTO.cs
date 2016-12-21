using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TomTatBanThanDTO
    {
        private int mId;
        private int mIdCongdan;
        private DateTime mNgayBatdau;
        private DateTime mNgayKetthuc;
        private string mChoO;
        private string mNghenghiep;
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

        public string ChoO
        {
            get
            {
                return mChoO;
            }

            set
            {
                mChoO = value;
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

        public TomTatBanThanDTO() { }

        public TomTatBanThanDTO(int mIdCongdan, DateTime mNgayBatdau, DateTime mNgayKetthuc, string mChoO, string mNghenghiep, string mGhichu, int mActive)
        {
            this.mIdCongdan = mIdCongdan;
            this.mNgayBatdau = mNgayBatdau;
            this.mNgayKetthuc = mNgayKetthuc;
            this.mChoO = mChoO;
            this.mNghenghiep = mNghenghiep;
            this.mGhichu = mGhichu;
            this.mActive = mActive;
        }
    }
}

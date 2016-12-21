using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VaiTroSoHoKhauDTO
    {
        private int mId;
        private string mTenVaitro;
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

        public string TenVaitro
        {
            get
            {
                return mTenVaitro;
            }

            set
            {
                mTenVaitro = value;
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

        private VaiTroSoHoKhauDTO() { }

        public VaiTroSoHoKhauDTO(string mTenVaitro, string mGhichu, int mActive)
        {
            this.mTenVaitro = mTenVaitro;
            this.mGhichu = mGhichu;
            this.mActive = mActive;
        }
    }
}

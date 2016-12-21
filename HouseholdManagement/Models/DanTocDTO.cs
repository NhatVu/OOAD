using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanTocDTO
    {
        private int mId;
        private string mTenDantoc;
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

        public string TenDantoc
        {
            get
            {
                return mTenDantoc;
            }

            set
            {
                mTenDantoc = value;
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

        public DanTocDTO() { }

        public DanTocDTO(string mTenDantoc, string mGhichu, int mActive)
        {
            this.mTenDantoc = mTenDantoc;
            this.mGhichu = mGhichu;
            this.mActive = mActive;
        }
    }
}

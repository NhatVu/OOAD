using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoleDTO
    {
        private string mId;
        private string mRoleName;
        private string mGhichu;
        private int mActive;

        public string Id
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

        public string RoleName
        {
            get
            {
                return mRoleName;
            }

            set
            {
                mRoleName = value;
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

        private RoleDTO() { }

        public RoleDTO(string mId, string mRoleName, string mGhichu, int mActive)
        {
            this.mId = mId;
            this.mRoleName = mRoleName;
            this.mGhichu = mGhichu;
            this.mActive = mActive;
        }
    }
}

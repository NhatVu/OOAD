using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserManagementDTO
    {
        private int mId;
        private int mIdRole;
        private string mEmail;
        private string mUsername;
        private string mPassword;
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

        public int IdRole
        {
            get
            {
                return mIdRole;
            }

            set
            {
                mIdRole = value;
            }
        }

        public string Email
        {
            get
            {
                return mEmail;
            }

            set
            {
                mEmail = value;
            }
        }

        public string Username
        {
            get
            {
                return mUsername;
            }

            set
            {
                mUsername = value;
            }
        }

        public string Password
        {
            get
            {
                return mPassword;
            }

            set
            {
                mPassword = value;
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

        public UserManagementDTO() { }

        public UserManagementDTO(int mIdRole, string mEmail, string mUsername, string mPassword, string mGhichu, int mActive)
        {
            this.mIdRole = mIdRole;
            this.mEmail = mEmail;
            this.mUsername = mUsername;
            this.mPassword = mPassword;
            this.mGhichu = mGhichu;
            this.mActive = mActive;
        }
    }
}

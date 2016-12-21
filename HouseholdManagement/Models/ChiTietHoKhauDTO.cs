using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoKhauDTO
    {
        private int mId;
        private int mIdHoKhau;
        private int mIdCDThanhVien;
        private int mIdKSThanhVien;
        private int mIdVaitroHokhau;
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

        public int IdHoKhau
        {
            get
            {
                return mIdHoKhau;
            }

            set
            {
                mIdHoKhau = value;
            }
        }

        public int IdCDThanhVien
        {
            get
            {
                return mIdCDThanhVien;
            }

            set
            {
                mIdCDThanhVien = value;
            }
        }

        public int IdKSThanhVien
        {
            get
            {
                return mIdKSThanhVien;
            }

            set
            {
                mIdKSThanhVien = value;
            }
        }

        public int IdVaitroHokhau
        {
            get
            {
                return mIdVaitroHokhau;
            }

            set
            {
                mIdVaitroHokhau = value;
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

        private ChiTietHoKhauDTO() { }

        public ChiTietHoKhauDTO(int mIdHoKhau, int mIdCDThanhVien, int mIdKSThanhVien, int mIdVaitroHokhau, string mGhichu, int mActive)
        {
            this.mIdHoKhau = mIdHoKhau;
            this.mIdCDThanhVien = mIdCDThanhVien;
            this.mIdKSThanhVien = mIdKSThanhVien;
            this.mIdVaitroHokhau = mIdVaitroHokhau;
            this.mGhichu = mGhichu;
            this.mActive = mActive;
        }
    }
}

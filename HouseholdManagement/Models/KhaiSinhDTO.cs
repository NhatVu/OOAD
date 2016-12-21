using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhaiSinhDTO
    {
        private int mId;
        private int mIdDantoc;
        private string mHoTen;
        private DateTime mNgaysinh;
        private int mGioitinh;
        private string mQuequan;
        private string mQuoctich;
        private int mIdCDCha;
        private int mIdCDMe;
        private string mNoiDangky;
        private DateTime mNgayDangky;
        private int mIdNguoiLamDon;
        private int mIdCDNguoiKy;
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

        public int IdDantoc
        {
            get
            {
                return mIdDantoc;
            }

            set
            {
                mIdDantoc = value;
            }
        }

        public string HoTen
        {
            get
            {
                return mHoTen;
            }

            set
            {
                mHoTen = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return mNgaysinh;
            }

            set
            {
                mNgaysinh = value;
            }
        }

        public int Gioitinh
        {
            get
            {
                return mGioitinh;
            }

            set
            {
                mGioitinh = value;
            }
        }

        public string Quequan
        {
            get
            {
                return mQuequan;
            }

            set
            {
                mQuequan = value;
            }
        }

        public string Quoctich
        {
            get
            {
                return mQuoctich;
            }

            set
            {
                mQuoctich = value;
            }
        }

        public int IdCDCha
        {
            get
            {
                return mIdCDCha;
            }

            set
            {
                mIdCDCha = value;
            }
        }

        public int IdCDMe
        {
            get
            {
                return mIdCDMe;
            }

            set
            {
                mIdCDMe = value;
            }
        }

        public string NoiDangky
        {
            get
            {
                return mNoiDangky;
            }

            set
            {
                mNoiDangky = value;
            }
        }

        public DateTime NgayDangky
        {
            get
            {
                return mNgayDangky;
            }

            set
            {
                mNgayDangky = value;
            }
        }

        public int IdNguoiLamDon
        {
            get
            {
                return mIdNguoiLamDon;
            }

            set
            {
                mIdNguoiLamDon = value;
            }
        }

        public int IdCDNguoiKy
        {
            get
            {
                return mIdCDNguoiKy;
            }

            set
            {
                mIdCDNguoiKy = value;
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

        public KhaiSinhDTO() { }

        public KhaiSinhDTO(int mIdDantoc, string mHoTen, DateTime mNgaysinh, int mGioitinh, string mQuequan, string mQuoctich, int mIdCDCha, int mIdCDMe, string mNoiDangky, DateTime mNgayDangky, int mIdNguoiLamDon, int midCDNguoiKy, string mGhichu, int mActive)
        {
            this.mIdDantoc = mIdDantoc;
            this.mHoTen = mHoTen;
            this.mNgaysinh = mNgaysinh;
            this.mGioitinh = mGioitinh;
            this.mQuequan = mQuequan;
            this.mQuoctich = mQuoctich;
            this.mIdCDCha = mIdCDCha;
            this.mIdCDMe = mIdCDMe;
            this.mNoiDangky = mNoiDangky;
            this.mNgayDangky = mNgayDangky;
            this.mIdNguoiLamDon = mIdNguoiLamDon;
            this.mIdCDNguoiKy = midCDNguoiKy;
            this.mGhichu = mGhichu;
            this.mActive = mActive;
        }
    }
}

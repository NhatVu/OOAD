﻿using System;
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
        private int mIdVaitroHokhau;
        private string mGhichu;
        private int mActive;
        public ChiTietHoKhauDTO()
        {
                
        }

        public ChiTietHoKhauDTO(int mIdHoKhau, int mIdCDThanhVien, int mIdVaitroHokhau, string mGhichu, int mActive)
        {
            this.mIdHoKhau = mIdHoKhau;
            this.mIdCDThanhVien = mIdCDThanhVien;
            this.mIdVaitroHokhau = mIdVaitroHokhau;
            this.mGhichu = mGhichu;
            this.mActive = mActive;
        }

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
    }
}

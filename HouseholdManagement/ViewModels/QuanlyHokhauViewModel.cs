﻿using DataAcessLayer;
using DTO;

using HouseholdManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DTO;
using DataAcessLayer;
using HouseholdManagement.Utilities;
using System.Data;

namespace HouseholdManagement
{
    class QuanlyHokhauViewModel
    {
        HoKhauDAO hoKhauDAO = new HoKhauDAO();
        private static QuanlyHokhauViewModel mInstace = null;
        public int Id { get; set; }
        public string TenCongAn { get; set; }
        public string TenChuHo { get; set; }
        public string NoiDangKyThuongTru { get; set; }
        public string NoiCap { get; set; }
        public DateTime NgayCap { get; set; }

        public static QuanlyHokhauViewModel createInstance(){
            if(mInstace == null)
                mInstace = new QuanlyHokhauViewModel();
            return mInstace;
        }

        public QuanlyHokhauViewModel(){

        }

        public List<QuanlyHokhauViewModel> getHoKhauAllInfo(){
            List<QuanlyHokhauViewModel> listhoKhau = new List<QuanlyHokhauViewModel>();

            DataTable hoKhauInfoSource = hoKhauDAO.GetAllInfo();
            int stt = 0;
            QuanlyHokhauViewModel hoKhauViewModelDTO = null;
            DataRow currentRow = null;
            for (int i = 0; i < hoKhauInfoSource.Rows.Count; i++)
            {
                stt++;
                currentRow = hoKhauInfoSource.Rows[i];
                hoKhauViewModelDTO = new QuanlyHokhauViewModel();
                hoKhauViewModelDTO.Id = Int32.Parse(currentRow["ID"].ToString());
                hoKhauViewModelDTO.TenCongAn = currentRow["congAn"].ToString();
                hoKhauViewModelDTO.TenChuHo = currentRow["chuHo"].ToString();
                hoKhauViewModelDTO.NoiDangKyThuongTru = currentRow["noiDangKyThuongTru"].ToString();
                hoKhauViewModelDTO.NgayCap = (DateTime)currentRow["ngayCap"];
                hoKhauViewModelDTO.NoiCap = currentRow["noiCap"].ToString();

                listhoKhau.Add(hoKhauViewModelDTO);
            }
            return listhoKhau;
        }
    }
}

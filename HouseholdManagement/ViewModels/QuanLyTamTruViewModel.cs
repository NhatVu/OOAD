using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAcessLayer;
using System.Data;

namespace HouseholdManagement.ViewModels
{
    class QuanLyTamTruViewModel
    {
        TamTruDAO tamTruDAO = new TamTruDAO();
        private static QuanLyTamTruViewModel mInstance = null;

        public int STT { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChiThuongTru { get; set; }

        public string CMND { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string GhiChu { get; set; }

        public QuanLyTamTruViewModel()
        {

        }

        public static QuanLyTamTruViewModel createInstace()
        {
            if (mInstance == null)
                mInstance = new QuanLyTamTruViewModel();
            return mInstance;
        }

        public List<QuanLyTamTruViewModel> getTamTruAllInfo()
        {
            List<QuanLyTamTruViewModel> listTamTru = new List<QuanLyTamTruViewModel>();

            DataTable tamTruInfoSource = tamTruDAO.GetAllInfo();
            int stt = 0;
            QuanLyTamTruViewModel tamTruViewModelDTO = null;
            DataRow currentRow = null;
            for (int i = 0; i < tamTruInfoSource.Rows.Count; i++)
            {
                stt++;
                currentRow = tamTruInfoSource.Rows[i];
                tamTruViewModelDTO = new QuanLyTamTruViewModel();
                tamTruViewModelDTO.STT = stt;
                tamTruViewModelDTO.HoTen = currentRow["hoTen"].ToString();
                tamTruViewModelDTO.NgaySinh = currentRow["ngaySinh"].ToString();

                if (Int32.Parse(currentRow["gioiTinh"].ToString()) == 1)
                    tamTruViewModelDTO.GioiTinh = "Nam";
                else
                    tamTruViewModelDTO.GioiTinh = "Nữ";

                tamTruViewModelDTO.DiaChiThuongTru = currentRow["diaChiThuongTru"].ToString();
                tamTruViewModelDTO.CMND = currentRow["cmnd"].ToString();
                tamTruViewModelDTO.NgayBatDau = (DateTime)currentRow["ngayBatDau"];
                tamTruViewModelDTO.NgayKetThuc = (DateTime)currentRow["ngayKetThuc"];
                tamTruViewModelDTO.GhiChu = currentRow["ghiChu"].ToString();

                listTamTru.Add(tamTruViewModelDTO);
            }
            return listTamTru;
        }
    }
}

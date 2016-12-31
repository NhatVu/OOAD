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
    class QuanLyTamVangViewModel
    {
        TamVangDAO TamVangDAO = new TamVangDAO();
        private static QuanLyTamVangViewModel mInstance = null;

        public int STT { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChiThuongTru { get; set; }

        public string CMND { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string GhiChu { get; set; }
        public int Id { get; set; }

        public QuanLyTamVangViewModel()
        {

        }

        public static QuanLyTamVangViewModel createInstace()
        {
            if (mInstance == null)
                mInstance = new QuanLyTamVangViewModel();
            return mInstance;
        }

        public List<QuanLyTamVangViewModel> getTamVangAllInfo()
        {
            List<QuanLyTamVangViewModel> listTamVang = new List<QuanLyTamVangViewModel>();

            DataTable TamVangInfoSource = TamVangDAO.GetAllInfo();
            int stt = 0;
            QuanLyTamVangViewModel TamVangViewModelDTO = null;
            DataRow currentRow = null;
            for (int i = 0; i < TamVangInfoSource.Rows.Count; i++)
            {
                stt++;
                currentRow = TamVangInfoSource.Rows[i];
                TamVangViewModelDTO = new QuanLyTamVangViewModel();
                TamVangViewModelDTO.STT = stt;
                TamVangViewModelDTO.Id = Int32.Parse(currentRow["id"].ToString());
                TamVangViewModelDTO.HoTen = currentRow["hoTen"].ToString();
                TamVangViewModelDTO.NgaySinh = ((DateTime)currentRow["ngaySinh"]).ToString("dd/MM/yyyy");

                if (Int32.Parse(currentRow["gioiTinh"].ToString()) == 1)
                    TamVangViewModelDTO.GioiTinh = "Nam";
                else
                    TamVangViewModelDTO.GioiTinh = "Nữ";

                TamVangViewModelDTO.DiaChiThuongTru = currentRow["diaChiThuongTru"].ToString();
                TamVangViewModelDTO.CMND = currentRow["cmnd"].ToString();
                TamVangViewModelDTO.NgayBatDau = (DateTime)currentRow["ngayBatDau"];
                TamVangViewModelDTO.NgayKetThuc = (DateTime)currentRow["ngayKetThuc"];
                TamVangViewModelDTO.GhiChu = currentRow["ghiChu"].ToString();

                listTamVang.Add(TamVangViewModelDTO);
            }
            return listTamVang;
        }

        public List<QuanLyTamVangViewModel> search(string query)
        {
            List<QuanLyTamVangViewModel> listTamVang = new List<QuanLyTamVangViewModel>();

            DataTable TamVangInfoSource = TamVangDAO.TamVangSearch(query);
            int stt = 0;
            QuanLyTamVangViewModel TamVangViewModelDTO = null;
            DataRow currentRow = null;
            for (int i = 0; i < TamVangInfoSource.Rows.Count; i++)
            {
                stt++;
                currentRow = TamVangInfoSource.Rows[i];
                TamVangViewModelDTO = new QuanLyTamVangViewModel();
                TamVangViewModelDTO.STT = stt;
                TamVangViewModelDTO.Id = Int32.Parse(currentRow["id"].ToString());
                TamVangViewModelDTO.HoTen = currentRow["hoTen"].ToString();
                TamVangViewModelDTO.NgaySinh = ((DateTime)currentRow["ngaySinh"]).ToString("dd/MM/yyyy");

                if (Int32.Parse(currentRow["gioiTinh"].ToString()) == 1)
                    TamVangViewModelDTO.GioiTinh = "Nam";
                else
                    TamVangViewModelDTO.GioiTinh = "Nữ";

                TamVangViewModelDTO.DiaChiThuongTru = currentRow["diaChiThuongTru"].ToString();
                TamVangViewModelDTO.CMND = currentRow["cmnd"].ToString();
                TamVangViewModelDTO.NgayBatDau = (DateTime)currentRow["ngayBatDau"];
                TamVangViewModelDTO.NgayKetThuc = (DateTime)currentRow["ngayKetThuc"];
                TamVangViewModelDTO.GhiChu = currentRow["ghiChu"].ToString();

                listTamVang.Add(TamVangViewModelDTO);
            }
            return listTamVang;
        }

    }
}

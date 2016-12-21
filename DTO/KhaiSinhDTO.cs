using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhaiSinhDTO
    {
        private int Id { get; set; }
        private int IdDanToc { get; set; }
        private string HoTen { get; set; }
        private DateTime NgaySinh { get; set; }
        private int GioiTinh { get; set; }
        private string QueQuan { get; set; }
        private string QuocTich { get; set; }
        private int IdCDCha { get; set; }
        private int IdCDMe { get; set; }
        private string NoiDangKy { get; set; }
        private DateTime NgayDangKy { get; set; }
        private int IdNguoiLamDon { get; set; }
        private int idCDNguoiKy { get; set; }

        private string GhiChu { get; set; }
        private int Active { get; set; }
        public KhaiSinhDTO() { }
        public KhaiSinhDTO(int idDanToc, string hoTen, DateTime ngaySinh, int gioiTinh, string queQuan, string quocTich, int idCDCha,
        int idCDMe, string noiDangKy, DateTime NgayDangKy, int idNguoiLamDon, int idCDNguoiKy, string ghiChu, int active)
        {
            this.IdDanToc = idDanToc;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.QueQuan = queQuan;
            this.QuocTich = quocTich;
            this.IdCDCha = idCDCha;
            this.IdCDMe = idCDMe;
            this.NoiDangKy = noiDangKy;
            this.IdNguoiLamDon = idNguoiLamDon;
            this.idCDNguoiKy = idCDNguoiKy;
            this.GhiChu = ghiChu;
            this.Active = active;
        }
    }
}

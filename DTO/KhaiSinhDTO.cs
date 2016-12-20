using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhaiSinhDTO
    {
        public int Id { get; set; }
        public int IdDanToc { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public string QuocTich { get; set; }
        public int IdCDCha { get; set; }
        public int IdCDMe { get; set; }
        public string NoiDangKy { get; set; }
        public DateTime NgayDangKy { get; set; }
        public int IdNguoiLamDon { get; set; }
        public int idCDNguoiKy { get; set; }

        public string GhiChu { get; set; }
        public int Active { get; set; }
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

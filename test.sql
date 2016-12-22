select * from HoKhau,ChiTietHoKhau,KhaiSinh
where ChiTietHoKhau.idHoKhau = 1;
and KhaiSinh.id = ChiTietHoKhau.idKSThanhVien
and ChiTietHoKhau.idVaiTroSoHoKhau = (Select id from VaiTroSoHoKhau where tenVaiTro = N'Chủ hộ')



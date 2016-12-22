SET IDENTITY_INSERT [dbo].[DanToc] ON 

INSERT [dbo].[DanToc] ([id], [tenDanToc], [ghiChu], [active]) VALUES (1, N'Kinh', NULL, 1)
INSERT [dbo].[DanToc] ([id], [tenDanToc], [ghiChu], [active]) VALUES (2, N'Mường', NULL, 1)
INSERT [dbo].[DanToc] ([id], [tenDanToc], [ghiChu], [active]) VALUES (3, N'Nùng', NULL, 1)
INSERT [dbo].[DanToc] ([id], [tenDanToc], [ghiChu], [active]) VALUES (4, N'Tày', NULL, 1)
INSERT [dbo].[DanToc] ([id], [tenDanToc], [ghiChu], [active]) VALUES (5, N'Thái', NULL, 1)
INSERT [dbo].[DanToc] ([id], [tenDanToc], [ghiChu], [active]) VALUES (6, N'Ba Na', NULL, 1)
INSERT [dbo].[DanToc] ([id], [tenDanToc], [ghiChu], [active]) VALUES (7, N'Chơ Ro', NULL, 1)
INSERT [dbo].[DanToc] ([id], [tenDanToc], [ghiChu], [active]) VALUES (8, N'Chăm', NULL, 1)
INSERT [dbo].[DanToc] ([id], [tenDanToc], [ghiChu], [active]) VALUES (9, N'Ê Đê', NULL, 1)
INSERT [dbo].[DanToc] ([id], [tenDanToc], [ghiChu], [active]) VALUES (10, N'Gia Rai', NULL, 1)
SET IDENTITY_INSERT [dbo].[DanToc] OFF
 -- vai tro ho khau
SET IDENTITY_INSERT [dbo].[VaiTroSoHoKhau] ON 

INSERT [dbo].[VaiTroSoHoKhau] ([id], [tenVaiTro], [ghiChu], [active]) VALUES (1, N'Chủ hộ', NULL, 1)
INSERT [dbo].[VaiTroSoHoKhau] ([id], [tenVaiTro], [ghiChu], [active]) VALUES (2, N'Chồng', NULL, 1)
INSERT [dbo].[VaiTroSoHoKhau] ([id], [tenVaiTro], [ghiChu], [active]) VALUES (3, N'Vợ', NULL, 1)
INSERT [dbo].[VaiTroSoHoKhau] ([id], [tenVaiTro], [ghiChu], [active]) VALUES (4, N'Con', NULL, 1)
INSERT [dbo].[VaiTroSoHoKhau] ([id], [tenVaiTro], [ghiChu], [active]) VALUES (5, N'Bố', NULL, 1)
INSERT [dbo].[VaiTroSoHoKhau] ([id], [tenVaiTro], [ghiChu], [active]) VALUES (6, N'Mẹ', NULL, 1)
INSERT [dbo].[VaiTroSoHoKhau] ([id], [tenVaiTro], [ghiChu], [active]) VALUES (7, N'Ông', NULL, 1)
INSERT [dbo].[VaiTroSoHoKhau] ([id], [tenVaiTro], [ghiChu], [active]) VALUES (8, N'Bà', NULL, 1)
INSERT [dbo].[VaiTroSoHoKhau] ([id], [tenVaiTro], [ghiChu], [active]) VALUES (9, N'Chú', NULL, 1)
INSERT [dbo].[VaiTroSoHoKhau] ([id], [tenVaiTro], [ghiChu], [active]) VALUES (10, N'Dì', NULL, 1)
INSERT [dbo].[VaiTroSoHoKhau] ([id], [tenVaiTro], [ghiChu], [active]) VALUES (11, N'Cô', NULL, 1)
INSERT [dbo].[VaiTroSoHoKhau] ([id], [tenVaiTro], [ghiChu], [active]) VALUES (12, N'Chú', NULL, 1)
SET IDENTITY_INSERT [dbo].[VaiTroSoHoKhau] OFF

-- khai sinh va cong dan
SET IDENTITY_INSERT [dbo].[CongDan] ON 
INSERT [dbo].[CongDan] ([id], [idDanToc], [hoTen], [ngaySinh], [gioiTinh], [queQuan], [quocTich], [idCDCha], [idCDMe], [noiDangKyKS], [ngayDangKyKS], [idNguoiLamDonKS], [idCDNguoiKyKS], [cmnd], [tonGiao], [ngheNghiep], [noiLamViec], [ngayCapCMND], [noiCap], [diaChiThuongTru], [trinhDoHocVan], [trinhDoChuyenMon], [trinhDoNgoaiNgu], [ghiChu], [active]) VALUES (1, 1, N'Vũ Minh Cha', CAST(N'1950-01-01 00:00:00.000' AS DateTime), 1, N'Hải Dương', N'Việt Nam', NULL, NULL, N'Hải Hương', CAST(N'1995-02-01 00:00:00.000' AS DateTime), NULL, NULL, 272481293, N'Công giáo', N'Nông dân', N'Đồng Nai', CAST(N'2010-03-03 00:00:00.000' AS DateTime), N'Đồng Nai', N'Đồng Nai', N'12/12', N'Nông dân', NULL, NULL, 1)
INSERT [dbo].[CongDan] ([id], [idDanToc], [hoTen], [ngaySinh], [gioiTinh], [queQuan], [quocTich], [idCDCha], [idCDMe], [noiDangKyKS], [ngayDangKyKS], [idNguoiLamDonKS], [idCDNguoiKyKS], [cmnd], [tonGiao], [ngheNghiep], [noiLamViec], [ngayCapCMND], [noiCap], [diaChiThuongTru], [trinhDoHocVan], [trinhDoChuyenMon], [trinhDoNgoaiNgu], [ghiChu], [active]) VALUES (2,1, N'Vũ Minh Mẹ', CAST(N'1951-03-01 00:00:00.000' AS DateTime), 0, N'Quảng Ninh', N'Việt Nam', NULL, NULL, N'Quảng Ninh', CAST(N'1951-05-01 00:00:00.000' AS DateTime), NULL, NULL, 272456829, N'Công Giáo', N'Làm rẫy', N'Đồng Nai', CAST(N'2011-04-05 00:00:00.000' AS DateTime), N'Đồng Nai', N'Đồng Nai', N'12/12', NULL, NULL, NULL, 1)
INSERT [dbo].[CongDan] ([id], [idDanToc], [hoTen], [ngaySinh], [gioiTinh], [queQuan], [quocTich], [idCDCha], [idCDMe], [noiDangKyKS], [ngayDangKyKS], [idNguoiLamDonKS], [idCDNguoiKyKS], [cmnd], [tonGiao], [ngheNghiep], [noiLamViec], [ngayCapCMND], [noiCap], [diaChiThuongTru], [trinhDoHocVan], [trinhDoChuyenMon], [trinhDoNgoaiNgu], [ghiChu], [active]) VALUES (3,1, N'Vũ Trưởng Công An', CAST(N'1970-06-07 00:00:00.000' AS DateTime), 1, N'Hà Nội', N'Việt Nam', NULL, NULL, N'Hà Nội', CAST(N'1970-08-07 00:00:00.000' AS DateTime), NULL, NULL, 869485726, N'Không', N'Cán bộ hộ khẩu', N'Đồng Nai', CAST(N'2013-07-21 00:00:00.000' AS DateTime), N'Hà Tĩnh', N'Đồng Nai', N'12/12', NULL, NULL, NULL, 1)
INSERT [dbo].[CongDan] ([id], [idDanToc], [hoTen], [ngaySinh], [gioiTinh], [queQuan], [quocTich], [idCDCha], [idCDMe], [noiDangKyKS], [ngayDangKyKS], [idNguoiLamDonKS], [idCDNguoiKyKS], [cmnd], [tonGiao], [ngheNghiep], [noiLamViec], [ngayCapCMND], [noiCap], [diaChiThuongTru], [trinhDoHocVan], [trinhDoChuyenMon], [trinhDoNgoaiNgu], [ghiChu], [active]) VALUES (4, 1, N'Vũ Minh Anh', CAST(N'1995-07-07 00:00:00.000' AS DateTime), 1, N'Đồng Nai', N'Việt Nam', 1, 2, N'Đồng Nai', CAST(N'1995-08-07 00:00:00.000' AS DateTime), 1, 3, 272456829, N'Công Giáo', N'Làm rẫy', N'Đồng Nai', CAST(N'2011-04-05 00:00:00.000' AS DateTime), N'Đồng Nai', N'Đồng Nai', N'12/12', NULL, NULL, NULL, 1)
INSERT [dbo].[CongDan] ([id], [idDanToc], [hoTen], [ngaySinh], [gioiTinh], [queQuan], [quocTich], [idCDCha], [idCDMe], [noiDangKyKS], [ngayDangKyKS], [idNguoiLamDonKS], [idCDNguoiKyKS], [cmnd], [tonGiao], [ngheNghiep], [noiLamViec], [ngayCapCMND], [noiCap], [diaChiThuongTru], [trinhDoHocVan], [trinhDoChuyenMon], [trinhDoNgoaiNgu], [ghiChu], [active]) VALUES (5, 1, N'Vũ Minh Em', CAST(N'1997-05-04 00:00:00.000' AS DateTime), 0, N'Đồng Nai', N'Việt Nam', 1, 2, N'Đồng Nai', CAST(N'1997-07-05 00:00:00.000' AS DateTime), 1, 3, 272456829, N'Công Giáo', N'Làm rẫy', N'Đồng Nai', CAST(N'2011-04-05 00:00:00.000' AS DateTime), N'Đồng Nai', N'Đồng Nai', N'12/12', NULL, NULL, NULL, 1)
INSERT [dbo].[CongDan] ([id], [idDanToc], [hoTen], [ngaySinh], [gioiTinh], [queQuan], [quocTich], [idCDCha], [idCDMe], [noiDangKyKS], [ngayDangKyKS], [idNguoiLamDonKS], [idCDNguoiKyKS], [cmnd], [tonGiao], [ngheNghiep], [noiLamViec], [ngayCapCMND], [noiCap], [diaChiThuongTru], [trinhDoHocVan], [trinhDoChuyenMon], [trinhDoNgoaiNgu], [ghiChu], [active]) VALUES (6, 2, N'Nguyễn Văn Cha', CAST(N'1970-05-01 00:00:00.000' AS DateTime), 1, N'Hà Tĩnh', N'Việt nam', NULL, NULL, N'Hà Tĩnh', CAST(N'1970-05-05 00:00:00.000' AS DateTime), NULL, NULL, 290495832, N'Phật giáo', N'Giáo viên', N'TP HCM', CAST(N'2015-01-01 00:00:00.000' AS DateTime), N' TP HCM', N'TP HCM', N'12/12', N'Giáo viên', N'Anh văn', NULL, 1)
INSERT [dbo].[CongDan] ([id], [idDanToc], [hoTen], [ngaySinh], [gioiTinh], [queQuan], [quocTich], [idCDCha], [idCDMe], [noiDangKyKS], [ngayDangKyKS], [idNguoiLamDonKS], [idCDNguoiKyKS], [cmnd], [tonGiao], [ngheNghiep], [noiLamViec], [ngayCapCMND], [noiCap], [diaChiThuongTru], [trinhDoHocVan], [trinhDoChuyenMon], [trinhDoNgoaiNgu], [ghiChu], [active]) VALUES (7, 1, N'Nguyễn Văn Mẹ', CAST(N'1980-04-05 00:00:00.000' AS DateTime), 0, N'An Giang', N'Việt Nam', NULL, NULL, N'An Giang', CAST(N'1980-05-05 00:00:00.000' AS DateTime), NULL, NULL, 294805928, N'Không', N'Cán bộ', N'TP HCM', CAST(N'2016-11-28 00:00:00.000' AS DateTime), N'TP HCM', N'TP HCM', N'12/12', N'Quản lý hành chính', N'Tiếng Hoa', NULL, 1)
INSERT [dbo].[CongDan] ([id], [idDanToc], [hoTen], [ngaySinh], [gioiTinh], [queQuan], [quocTich], [idCDCha], [idCDMe], [noiDangKyKS], [ngayDangKyKS], [idNguoiLamDonKS], [idCDNguoiKyKS], [cmnd], [tonGiao], [ngheNghiep], [noiLamViec], [ngayCapCMND], [noiCap], [diaChiThuongTru], [trinhDoHocVan], [trinhDoChuyenMon], [trinhDoNgoaiNgu], [ghiChu], [active]) VALUES (8, 1, N'Nguyễn Văn Con Trai', CAST(N'1990-05-05 00:00:00.000' AS DateTime), 1, N'An Giang', N'Việt Nam', 6, 7, N'An Giang', CAST(N'1990-06-15 00:00:00.000' AS DateTime), NULL, NULL, 294805929, N'Không', N'Sinh viên', N'TP HCM', CAST(N'2015-12-28 00:00:00.000' AS DateTime), N'TP HCM', N'TP HCM', N'11/12', NULL, N'Tiếng Hoa', NULL, 1)
INSERT [dbo].[CongDan] ([id], [idDanToc], [hoTen], [ngaySinh], [gioiTinh], [queQuan], [quocTich], [idCDCha], [idCDMe], [noiDangKyKS], [ngayDangKyKS], [idNguoiLamDonKS], [idCDNguoiKyKS], [cmnd], [tonGiao], [ngheNghiep], [noiLamViec], [ngayCapCMND], [noiCap], [diaChiThuongTru], [trinhDoHocVan], [trinhDoChuyenMon], [trinhDoNgoaiNgu], [ghiChu], [active]) VALUES (9, 1, N'Nguyễn Văn Con Gái', CAST(N'1999-10-21 00:00:00.000' AS DateTime), 0, N'TP HCM', N'Việt Nam', NULL, NULL, N'An Giang', CAST(N'1999-10-25 00:00:00.000' AS DateTime), NULL, NULL, NULL, N'Không', N'Học Sinh', N'TP HCM', CAST(N'2016-11-28 00:00:00.000' AS DateTime), N'TP HCM', N'TP HCM', N'10/12', N'Học Sinh', N'Tiếng Hoa', NULL, 1)
INSERT [dbo].[CongDan] ([id], [idDanToc], [hoTen], [ngaySinh], [gioiTinh], [queQuan], [quocTich], [idCDCha], [idCDMe], [noiDangKyKS], [ngayDangKyKS], [idNguoiLamDonKS], [idCDNguoiKyKS], [cmnd], [tonGiao], [ngheNghiep], [noiLamViec], [ngayCapCMND], [noiCap], [diaChiThuongTru], [trinhDoHocVan], [trinhDoChuyenMon], [trinhDoNgoaiNgu], [ghiChu], [active]) VALUES (10, 1, N'Nguyễn Trưởng Công An', CAST(N'1980-10-20 00:00:00.000' AS DateTime), 0, N'TP HCM', N'Việt Nam', NULL, NULL, N'An Giang', CAST(N'1970-10-25 00:00:00.000' AS DateTime), NULL, NULL, 236808328, N'Không', N'Trưởng Công An', N'TP HCM', CAST(N'2016-11-28 00:00:00.000' AS DateTime), N'TP HCM', N'TP HCM', N'12/12', N'Công An hành chính', N'Tiếng Hoa', NULL, 1)

SET IDENTITY_INSERT [dbo].[CongDan] OFF

SET IDENTITY_INSERT [dbo].[HoKhau] ON 

INSERT [dbo].[HoKhau] ([id], [idCDTruongCongAn], [noiCap],[ngayCap], [noiDangKyThuongTru], [ghiChu], [active]) VALUES (1, 3, N'Đồng Nai', CAST(N'1980-04-05 00:00:00.000' AS DateTime), N'Đồng Nai', NULL, 1)
INSERT [dbo].[HoKhau] ([id], [idCDTruongCongAn], [noiCap],[ngayCap], [noiDangKyThuongTru], [ghiChu], [active]) VALUES (2, 10, N'TP HCM', CAST(N'1985-04-06 00:00:00.000' AS DateTime), N'TP HCM', NULL, 1)
SET IDENTITY_INSERT [dbo].[HoKhau] OFF

SET IDENTITY_INSERT [dbo].[ChiTietHoKhau] ON 
INSERT [dbo].[ChiTietHoKhau] ([id], [idHoKhau], [idCDThanhVien], [idVaiTroSoHoKhau], [ghiChu], [active]) VALUES (1, 1, 1, 1, NULL, 1)
INSERT [dbo].[ChiTietHoKhau] ([id], [idHoKhau], [idCDThanhVien], [idVaiTroSoHoKhau], [ghiChu], [active]) VALUES (2, 1, 2, 3, NULL, 1)
INSERT [dbo].[ChiTietHoKhau] ([id], [idHoKhau], [idCDThanhVien], [idVaiTroSoHoKhau], [ghiChu], [active]) VALUES (3, 1, 4, 4, NULL, 1)
INSERT [dbo].[ChiTietHoKhau] ([id], [idHoKhau], [idCDThanhVien], [idVaiTroSoHoKhau], [ghiChu], [active]) VALUES (4, 1, 5, 4, NULL, 1)
INSERT [dbo].[ChiTietHoKhau] ([id], [idHoKhau], [idCDThanhVien], [idVaiTroSoHoKhau], [ghiChu], [active]) VALUES (5, 2, 6, 2, NULL, 1)
INSERT [dbo].[ChiTietHoKhau] ([id], [idHoKhau], [idCDThanhVien], [idVaiTroSoHoKhau], [ghiChu], [active]) VALUES (6, 2, 7, 1, NULL, 1)
INSERT [dbo].[ChiTietHoKhau] ([id], [idHoKhau], [idCDThanhVien], [idVaiTroSoHoKhau], [ghiChu], [active]) VALUES (7, 2, 8, 4,NULL, 1)
INSERT [dbo].[ChiTietHoKhau] ([id], [idHoKhau], [idCDThanhVien], [idVaiTroSoHoKhau], [ghiChu], [active]) VALUES (8, 2, 9, 4,NULL, 1)
SET IDENTITY_INSERT [dbo].[ChiTietHoKhau] OFF




SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([id], [roleName], [ghiChu], [active]) VALUES (1, N'Công An', NULL, 1)
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[TamTru] ON 

INSERT [dbo].[TamTru] ([id], [idCongDan], [idTruongCongAn], [ngayBatDau], [ngayKetThuc], [lyDo], [diaChiDen], [ngayLamDon], [ghiChu], [active]) VALUES (1, 1, 7, CAST(N'2015-01-01 00:00:00.000' AS DateTime), CAST(N'2015-03-01 00:00:00.000' AS DateTime), N'Công tác tại Hà Nội', N'Hà Nội', CAST(N'2015-01-01 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[TamTru] ([id], [idCongDan], [idTruongCongAn], [ngayBatDau], [ngayKetThuc], [lyDo], [diaChiDen], [ngayLamDon], [ghiChu], [active]) VALUES (2, 4, 8, CAST(N'2016-04-05 00:00:00.000' AS DateTime), CAST(N'2016-06-07 00:00:00.000' AS DateTime), N'Về quê', N'Hà Tĩnh', CAST(N'2016-04-05 00:00:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[TamTru] OFF
SET IDENTITY_INSERT [dbo].[TamVang] ON 

INSERT [dbo].[TamVang] ([id], [idCongDan], [idTruongCongAn], [ngayBatDau], [ngayKetThuc], [lyDo], [diaChiDen], [ngayLamDon], [ghiChu], [active]) VALUES (1, 2, 7, CAST(N'2016-01-01 00:00:00.000' AS DateTime), CAST(N'2106-03-01 00:00:00.000' AS DateTime), N'Về quê', N'An Giang', CAST(N'2016-01-01 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[TamVang] ([id], [idCongDan], [idTruongCongAn], [ngayBatDau], [ngayKetThuc], [lyDo], [diaChiDen], [ngayLamDon], [ghiChu], [active]) VALUES (2, 8, 8, CAST(N'2016-03-02 00:00:00.000' AS DateTime), CAST(N'2016-04-05 00:00:00.000' AS DateTime), N'Lên nhà bạn', N'TP HCM', CAST(N'2016-03-02 00:00:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[TamVang] OFF
SET IDENTITY_INSERT [dbo].[TienAn] ON 

INSERT [dbo].[TienAn] ([id], [idCongDan], [toiDanh], [hinhPhat], [ngayThang], [noiTuyenAn], [ghiChu], [active]) VALUES (1, 7, N'Đánh nhau', N'Quản chế tại nahf 3 tuần', CAST(N'1995-01-01 00:00:00.000' AS DateTime), N'Hải phòng', NULL, 1)
INSERT [dbo].[TienAn] ([id], [idCongDan], [toiDanh], [hinhPhat], [ngayThang], [noiTuyenAn], [ghiChu], [active]) VALUES (2, 6, N'Cướp tài sản', N'Tù 2 tháng', CAST(N'2000-04-05 00:00:00.000' AS DateTime), N'Đồng Nai', NULL, 1)
INSERT [dbo].[TienAn] ([id], [idCongDan], [toiDanh], [hinhPhat], [ngayThang], [noiTuyenAn], [ghiChu], [active]) VALUES (3, 7, N'Đánh bạc', N'Tù 1 tháng', CAST(N'2000-01-12 00:00:00.000' AS DateTime), N'Đồng Nai', NULL, 1)
SET IDENTITY_INSERT [dbo].[TienAn] OFF
SET IDENTITY_INSERT [dbo].[TomTatBanThan] ON 

INSERT [dbo].[TomTatBanThan] ([id], [idCongDan], [ngayBatDau], [ngayKetThuc], [choO], [ngheNghiep], [ghiChu], [active]) VALUES (1, 1, CAST(N'1950-01-01 00:00:00.000' AS DateTime), CAST(N'1965-01-01 00:00:00.000' AS DateTime), N'Hải Dương', N'Còn nhở, ở với gia đình', NULL, 1)
INSERT [dbo].[TomTatBanThan] ([id], [idCongDan], [ngayBatDau], [ngayKetThuc], [choO], [ngheNghiep], [ghiChu], [active]) VALUES (2, 1, CAST(N'1965-01-02 00:00:00.000' AS DateTime), CAST(N'1985-01-01 00:00:00.000' AS DateTime), N'An Giang', N'Đánh bắt cá', NULL, 1)
INSERT [dbo].[TomTatBanThan] ([id], [idCongDan], [ngayBatDau], [ngayKetThuc], [choO], [ngheNghiep], [ghiChu], [active]) VALUES (3, 1, CAST(N'1986-03-02 00:00:00.000' AS DateTime), CAST(N'2015-12-20 00:00:00.000' AS DateTime), N'Đồng Nai', N'Làm rẫy', NULL, 1)
INSERT [dbo].[TomTatBanThan] ([id], [idCongDan], [ngayBatDau], [ngayKetThuc], [choO], [ngheNghiep], [ghiChu], [active]) VALUES (4, 2, CAST(N'1951-01-03 00:00:00.000' AS DateTime), CAST(N'1970-01-01 00:00:00.000' AS DateTime), N'Quảng Ninh', N'Còn nhỏ, ở với gia đình', NULL, 1)
INSERT [dbo].[TomTatBanThan] ([id], [idCongDan], [ngayBatDau], [ngayKetThuc], [choO], [ngheNghiep], [ghiChu], [active]) VALUES (5, 2, CAST(N'1970-01-02 00:00:00.000' AS DateTime), CAST(N'1985-01-01 00:00:00.000' AS DateTime), N'Huế', N'Học đại học', NULL, 1)
INSERT [dbo].[TomTatBanThan] ([id], [idCongDan], [ngayBatDau], [ngayKetThuc], [choO], [ngheNghiep], [ghiChu], [active]) VALUES (6, 2, CAST(N'1985-01-02 00:00:00.000' AS DateTime), CAST(N'2016-01-01 00:00:00.000' AS DateTime), N'Đồng Nai', N'Làm rẫy', NULL, 1)
INSERT [dbo].[TomTatBanThan] ([id], [idCongDan], [ngayBatDau], [ngayKetThuc], [choO], [ngheNghiep], [ghiChu], [active]) VALUES (7, 3, CAST(N'1970-06-07 00:00:00.000' AS DateTime), CAST(N'1985-01-01 00:00:00.000' AS DateTime), N'Hà Nội', N'Học sinh', NULL, 1)
INSERT [dbo].[TomTatBanThan] ([id], [idCongDan], [ngayBatDau], [ngayKetThuc], [choO], [ngheNghiep], [ghiChu], [active]) VALUES (8, 3, CAST(N'1988-01-02 00:00:00.000' AS DateTime), CAST(N'1998-01-01 00:00:00.000' AS DateTime), N'Hà Nội', N'Sinh viên', NULL, 1)
INSERT [dbo].[TomTatBanThan] ([id], [idCongDan], [ngayBatDau], [ngayKetThuc], [choO], [ngheNghiep], [ghiChu], [active]) VALUES (9, 3, CAST(N'1998-01-02 00:00:00.000' AS DateTime), CAST(N'2016-01-01 00:00:00.000' AS DateTime), N'Đồng Nai', N'Cán bộ quản lý hộ khẩu', NULL, 1)
SET IDENTITY_INSERT [dbo].[TomTatBanThan] OFF

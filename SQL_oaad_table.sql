use master;
create database QuanLyHoKhau;
go
use QuanLyHoKhau;

create table DanToc (
	id int identity(1,1) primary key,
	tenDanToc nvarchar(50),
	ghiChu nvarchar(300),
	active int
)


create table CongDan (
	id int IDENTITY(1,1) primary key,
	idDanToc int,
	hoTen nvarchar(50),
	ngaySinh datetime,
	gioiTinh int,
	queQuan nvarchar(100),
	quocTich nvarchar(100),
	idCDCha int,
	idCDMe int,
	noiDangKyKS nvarchar(100),
	ngayDangKyKS datetime,
	idNguoiLamDonKS int,
	idCDNguoiKyKS int,
	cmnd int,
	tonGiao nvarchar(50),
	ngheNghiep nvarchar(100),
	noiLamViec nvarchar(300),
	ngayCapCMND datetime, 
	noiCap nvarchar(100),
	diaChiThuongTru nvarchar(300),
	trinhDoHocVan nvarchar(30),
	trinhDoChuyenMon nvarchar(100),
	trinhDoNgoaiNgu nvarchar(100),
	ghiChu nvarchar(300),
	active int,


	constraint FK_CDCha_CongDan foreign key(idCDCha) references CongDan(id),
	constraint FK_CDMe_CongDan foreign key(idCDMe) references CongDan(id),
	constraint FK_CDNguoiLamDon_CongDan foreign key(idNguoiLamDonKS) references CongDan(id),
	constraint FK_CDNguoiKy_CongDan foreign key(idCDNguoiKyKS) references CongDan(id),
	constraint FK_CongDan_DanToc foreign key(idDanToc) references DanToc(id)
)

create table CongAn (
	id int primary key,
	email varchar(50),
	username varchar(20),
	password varchar(500),
	ghiChu nvarchar(300),
	active int
	constraint FK_CongAn_CongDan foreign key (id) references CongDan(id)
)

create table TomTatBanThan (
	id int IDENTITY(1,1) primary key,
	idCongDan int,
	ngayBatDau datetime,
	ngayKetThuc datetime,
	choO nvarchar(100), /*choox owr*/
	ngheNghiep nvarchar(100),
	ghiChu nvarchar(300),
	active int,
	constraint FK_TomTatBanThan_CongDan foreign key(idCongDan) references CongDan(id)
)


create table TienAn(
	id int IDENTITY(1,1) primary key,
	idCongDan int, 
	toiDanh nvarchar(300),
	hinhPhat nvarchar(300),
	ngayThang datetime,
	noiTuyenAn nvarchar(300),
	ghiChu nvarchar(300),
	active int,
	constraint FK_TienAn_CongDan foreign key(idCongDan) references CongDan(id),
)


create table VaiTroSoHoKhau(
	id int identity(1,1) primary key,
	tenVaiTro nvarchar(100),
	ghiChu nvarchar(300),
	active int
)

create table HoKhau (
	id int identity(1,1) primary key,
	idCDTruongCongAn int,
	noiCap nvarchar(300),
	ngayCap datetime,
	noiDangKyThuongTru nvarchar(300),
	ghiChu nvarchar(300),
	active int

	constraint FK_HoKhau_CongAn foreign key(idCDTruongCongAn) references CongAn(id)
)

create table ChiTietHoKhau(
	id int identity(1,1) primary key,
	idHoKhau int,
	idCDThanhVien int,
	idVaiTroSoHoKhau int,
	ghiChu nvarchar(300),
	active int,

	constraint FK_ChiTietHoKhau_HoKhau foreign key (idHoKhau) references HoKhau(id),
	constraint FK_ChiTietHoKhau_VaiTroSoHoKhau foreign key (idVaiTroSoHoKhau) references VaiTroSoHoKhau(id),
	constraint FK_ChiTietHoKhau_CongDan foreign key (idCDThanhVien) references CongDan(id)
)

create table TamVang (
	id int identity(1,1) primary key,
	idCongDan int,
	idTruongCongAn int,
	ngayBatDau datetime,
	ngayKetThuc datetime,
	lyDo nvarchar(300),
	diaChiDen nvarchar(300),
	ngayLamDon datetime,
	ghiChu nvarchar(300),
	active int,

	constraint FK_TamVang_CongDan foreign key (idCongDan) references CongDan(id),
	constraint FK_TamVang_TruongCongAn foreign key (idTruongCongAn) references CongAn(id)
	
)

create table ChuyenKhau (
	id int identity(1,1) primary key,
	idCongDan int,
	idHoKhauCu int,
	idHoKhauMoi int,
	lyDo nvarchar(300),
	idVaiTroSoHoKhau int,
	ghiChu nvarchar(300),
	active int,
	constraint FK_ChuyenKhau_CongDan foreign key (idCongDan) references CongDan(id),
	constraint FK_ChuyenKhau_HoKhauCu foreign key(idHoKhauCu) references HoKhau(id),
	constraint FK_ChuyenKhau_HoKhauMoi foreign key(idHoKhauMoi) references HoKhau(id),
	constraint FK_ChuyenKhau_VaiTroSoHoKhau foreign key (idVaiTroSoHoKhau) references VaiTroSoHoKhau(id)
)

create table TamTru (
	id int identity(1,1) primary key,
	idCongDan int,
	idTruongCongAn int,
	ngayBatDau datetime,
	ngayKetThuc datetime,
	lyDo nvarchar(300),
	diaChiDen nvarchar(300),
	ngayLamDon datetime,
	ghiChu nvarchar(300),
	active int,

	constraint FK_TamTru_CongDan foreign key (idCongDan) references CongDan(id),
	constraint FK_TamTru_TruongCongAn foreign key (idTruongCongAn) references CongAn(id)
)





create table LichSuHoKhau (
	id int identity(1,1) primary key,
	originalId int,
	hoTenTruongCongAn nvarchar(100),
	hoTenThanhVien nvarchar(100),
	vaiTro nvarchar(100),
	thoiGianThayDoi datetime,
)




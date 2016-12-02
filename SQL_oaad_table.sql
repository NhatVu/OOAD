
drop database QuanLyHoKhau;
create database QuanLyHoKhau;
go
use QuanLyHoKhau;

create table Role (
	id int IDENTITY(1,1) primary key,
	roleName nvarchar(50) not null
)

create table UserManagement (
	id int identity(1,1) primary key,
	idRole int,
	email varchar(50) not null,
	username varchar(20) not null,
	password varchar(500) not null,
	
	constraint FK_UserManagement_Role foreign key (idRole) references Role(id)
)



create table DanToc (
	id int identity(1,1) primary key,
	tenDanToc nvarchar(50)
)

create table KhaiSinh(
	id int IDENTITY(1,1) primary key,
	idDanToc int,
	hoTen nvarchar(50),
	ngaySinh datetime,
	gioiTinh int,
	queQuan nvarchar(100),
	quocTich nvarchar(100),
	idKhaiSinhCha int,
	idKhaiSinhMe int,
	noiDangKy nvarchar(100),
	ngayDangKy datetime,
	idNguoiLamDon int,
	idNguoiKy int,

	constraint FK_KhaiSinh_DanToc foreign key(idDanToc) references DanToc(id)
)

create table CongDan (
	id int IDENTITY(1,1) primary key,
	idKhaiSinh int not null,
	cmnd int not null,
	tonGiao nvarchar(50),
	ngheNghiep nvarchar(100),
	noiLamViec nvarchar(100),
	ngayCapCMND datetime, 
	noiCap nvarchar(100),
	diaChiThuongTru nvarchar(100),
	trinhDoHocVan nvarchar(30),
	trinhDoChuyenMon nvarchar(100),
	trinhDoNgoaiNgu nvarchar(100),

	constraint FK_CongDan_KhaiSinh foreign key(idKhaiSinh) references KhaiSinh(id)
)


create table TomTatBanThan (
	id int IDENTITY(1,1) primary key,
	idCongDan int,
	ngayBatDau datetime,
	ngayKetThuc datetime,
	choO nvarchar(100), /*choox owr*/
	ngheNghiep nvarchar(100),
	constraint FK_TomTatBanThan_CongDan foreign key(idCongDan) references CongDan(id)
)


create table TienAn(
	id int IDENTITY(1,1) primary key,
	idCongDan int, 
	toiDanh nvarchar(100),
	hinhPhat nvarchar(300),
	ngayThang datetime,
	noiTuyenAn nvarchar(100),
	constraint FK_TienAn_CongDan foreign key(idCongDan) references CongDan(id),
)


create table VaiTroSoHoKhau(
	id int identity(1,1) primary key,
	tenVaiTro nvarchar(50)
)

create table HoKhau (
	id int identity(1,1) primary key,
	idChuHo int,

	constraint FK_HoKhau_CongDan foreign key(idChuHo) references CongDan(id)
)

create table ChiTietHoKhau(
	id int identity(1,1) primary key,
	idHoKhau int,
	idThanhVien int,
	idVaiTroSoHoKhau int,

	constraint FK_ChiTietHoKhau_HoKhau foreign key (idHoKhau) references HoKhau(id),
	constraint FK_ChiTietHoKhau_VaiTroSoHoKhau foreign key (idVaiTroSoHoKhau) references VaiTroSoHoKhau(id)
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

	constraint FK_TamVang_CongDan foreign key (idCongDan) references CongDan(id),
	constraint FK_TamVang_TruongCongAn foreign key (idTruongCongAn) references CongDan(id)
	
)

create table ChuyenKhau (
	id int identity(1,1) primary key,
	idCongDan int,
	idHoKhauCu int,
	idHoKhauMoi int,

	constraint FK_ChuyenKhau_CongDan foreign key (idCongDan) references CongDan(id),
	constraint FK_ChuyenKhau_HoKhauCu foreign key(idHoKhauCu) references HoKhau(id),
	constraint FK_ChuyenKhau_HoKhauMoi foreign key(idHoKhauMoi) references HoKhau(id)
)

create table TamTru (
	id int identity(1,1) primary key,
	idCongDan int,
	idHoKhau int, /*( lấy thông tin bố, mẹ, chồng, con )*/
	idTienAn int,

	constraint FK_TamTru_CongDan foreign key (idCongDan) references CongDan(id),
	constraint FK_TamTru_HoKhauCu foreign key(idHoKhau) references HoKhau(id),
	constraint FK_TamTru_TienAn foreign key (idTienAn) references TienAn(id)
)




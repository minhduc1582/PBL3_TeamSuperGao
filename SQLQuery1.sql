create database MVH_02
go
use MVH_02
--danh muc mon
create table DanhMucMon
(
	IDDanhMucMon int primary key,
	TenDanhMuc nvarchar(50),
)
--thuc don cua quan
create table Mon
(
	IDMon int IDENTITY(1,1) primary key,
	TenMon nvarchar(50),
	DonGia float,
	--HinhAnh image,
	IDDanhMucMon int foreign key (IDDanhMucMon) references DanhMucMon,
)
-- tai khoan
create table TaiKhoan
(
	IDTaiKhoan int IDENTITY(1,1) primary key,
	UserName char(20),
	PassWord char(20) not null default 0 ,
)
--chuc vu
create table ChucVu
(
	IDChucVu int primary key,
	TenChucVu nvarchar(50),
)
-- the hien thong tin nhan vien 
create table NhanVien
(
	IDNhanVien int IDENTITY(1,1) primary key,
	HoTen nvarchar(50) not null,
	DanToc nvarchar(30) not null,
	GioiTinh bit not null,
	SoDienThoai char(12) not null,
	QueQuan char(30) not null,
	NgaySinh date not null,
	TrinhDoHocVan nvarchar(30),
	[IDChucVu] int foreign key (IDChucVu) references ChucVu,
	[IDTaiKhoan] int foreign key ([IDTaiKhoan]) references TaiKhoan,
)


--Quan ly ban va tinh trang ban
create table Ban
(
	IDBan int IDENTITY(1,1) primary key,
	TinhTrangBan nvarchar(12) not null default 'Trong',
)

--hoa don
create table HoaDon
(
	IDHoaDon int IDENTITY(1,1) primary key,
	-- Giam gia tinh theo %
	GiamGia float,
	TinhTrang nvarchar(20) not null default 'Chua Thanh Toan',
	TongTien float,
	IDBan int foreign key (IDBan) references Ban,
	IDNhanVien int foreign key (IDNhanVien) references NhanVien,
)
--chi tiet ban 
create table ChiTietHoaDon
(
	IDHoaDon int foreign key (IDHoaDon) references HoaDon,
	[IDMon] int foreign key ([IDMon]) references Mon,
	NgayThanhToan date,
	SoLuong int,
	primary key(IDMon,IDHoaDon),
)
insert into Ban values
('Trong'),
('Trong'),
('Trong'),
('Trong'),
('Trong'),
('Trong'),
('Trong'),
('Trong'),
('Trong'),
('Trong')
insert into TaiKhoan values
('user','pass')
insert into ChucVu values
(1,'Quan ly'),
(2,'Nhan vien'),
(3,'Giu xe')
Insert into DanhMucMon values
(1,'Banh My'),
(2,'Coffe'),
(3,'Freeze'),
(4,'Tra')
insert into Mon values
( 'Banh My Cha', 19000, 1),
( 'Banh My Thit Nuong', 19000, 1),
( 'Banh My Xiu Mai', 19000, 1),
( 'Banh My Ga Xe', 19000, 1),
( 'Phin Den', 29000, 2),
( 'Phin Sua', 29000, 2),
( 'Bac Xiu', 29000, 2),
( 'Caramel Freeze', 49000, 3),
( 'Tra Xanh', 49000, 4),
( 'Cookies & Cream', 49000, 3),
( 'Chocolate Freeze', 49000, 3),
( 'Classic Freeze', 49000, 3),
( 'Phindi Choco', 39000, 2),
( 'Phindi Hanh Nhan', 39000, 2),
( 'Phindi Kem Sua', 39000, 2),
( 'Tra Vai', 39000, 4),
( 'Tra Dao', 39000, 4),
( 'Tra Sen', 39000, 4)
insert into NhanVien values
('Nguyen Phuoc Phuc','Kinh',0,'0365143400','Hue','5/21/2021','Dai hoc',1,1),
('Nguyen Minh Duc','Kinh',0,'0365143401','Hue','8/15/2021','Dai hoc',2,1),
('Nguyen Minh Tri','Kinh',0,'0365143402','Hue','8/10/2021','Dai hoc',2,1),
('Le Nguyen Quang Tan','Kinh',0,'0365143402','Hue','6/12/2021','Dai hoc',3,1)
insert into HoaDon values
(2,'Da Thanh Toan',48020,1,2),
(0,'Da Thanh Toan',19000,2,3)
insert into ChiTietHoaDon values
(1,8,'5/5/2021',2),
(2,1,'7/5/2021',1)

select * from HoaDon as hd inner join ChiTietHoaDon as ct on hd.IDHoaDon = ct.IDHoaDon

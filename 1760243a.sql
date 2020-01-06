create database LTUDQL
go

use LTUDQL
go

create table NguoiDung
(
	ID int  not null IDENTITY(1,1),
	CMND varchar(50) not null,
	Loainguoidung int not null,
	TaiKhoan varchar(50) null,
	Matkhau varchar(50) null,

	constraint FK_NguoiDung primary key(ID),
	constraint CHECK_Loai check(Loainguoidung>=1 and Loainguoidung <=3),
	constraint UN_CMND UNIQUE(CMND)
)
go

create table HocSinh
(
	ID int not null,
	Lop int not null,
	Khoi int not null,
	Hoten nvarchar(50)null,
	Ngaysinh date null,

	constraint FK_HocSinh primary key(ID,Lop,Khoi)
)
go

create table GiaoVien
(
	ID int not null,
	Hoten nvarchar(50) null,
	Ngaysinh date null,

	constraint FK_GiaoVien primary key(ID)
)
go

create table QuanTri
(
	ID int not null,
	Hoten nvarchar(50) null,
	Ngaysinh date null,

	constraint FK_QuanTri primary key(ID)
)
go

create table CauHoi
(
	ID int not null,
	Khoi int not null,
	Mota nvarchar(255) not null,
	Duyet bit not null,
	IDNguoitao int not null,
	Dokho int default 1,
	constraint FK_CauHoi primary key(ID,Khoi),
	constraint FK_Dokho check(Dokho >=1 and Dokho <=4)
)

go

create table CT_CauHoi
(
	IDCauhoi int not null,
	Khoi int not null,
	IDdapan nchar(2) not null,
	Mota nvarchar(255),
	Dung bit not null,

	constraint FK_CTCauHoi primary key(IDCauhoi,Khoi,IDDapan)
)
go

create table KyThi
(
	ID int not null,
	Khoi int not null,
	Thithu int not null default 0,
	IDNguoitao int not null,
	Gioihanthoigian int not null default 0,
	Ngaytao date default getdate(),
	Ngaythi date default getdate(),
	constraint FK_KyThi primary key(ID,Khoi),
	constraint FK_Thithu check(Thithu>=0 and Thithu <=3)
)
go

select * From KyThi

create table MaDe
(
	ID int not null,
	Khoi int not null,
	IDNguoitao int not null,
	Dokho nvarchar(10) not null,

	constraint FK_MaDe primary key(ID,Khoi),
	constraint CK_Dokho check(Dokho = N'Dễ' or Dokho = N'Khó' or Dokho = N'Trung bình' or Dokho = N'Rất khó')
)

go

create table CT_MaDe
(
	IDMade int not null,
	Khoimade int not null,
	IDCauhoi int not null,
	Khoicauhoi int not null,
	IDDapan nchar(2) not null,
	constraint FK_CTMade primary key(IDMade,Khoimade,IDCauhoi,Khoicauhoi,IDDapan)

)
go

create table CT_KyThi
(
	IDKythi int not null,
	Khoikythi int not null,
	IDMade int not null,
	Khoidethi int not null,

	constraint FK_CTKythi primary key(IDKythi,Khoikythi,IDMade,Khoidethi)
)
go

create table CT_ThamGia
(
	IDKythi int not null,
	Khoikythi int not null,
	IDMade int not null,
	Khoidethi int not null,
	IDHocsinh int not null,
	Lop int not null,
	Khoi int not null,
	Diem real null,

	constraint FK_CTThamgia primary key(IDKythi,Khoikythi,IDMade,Khoidethi,IDHocsinh,Lop,Khoi)
)
go

create table CT_KetQua
(
	IDKythi int not null,
	Khoikythi int not null,
	IDMade int not null,
	Khoidethi int not null,
	IDHocsinh int not null,
	Lop int,
	Khoi int,
	IDCauhoi int not null,
	Khoicauhoi int not null,
	IDDapan nchar(2) not null,
	Traloi bit null,
	Motacauhoi nvarchar(255),
	Motadapan nvarchar(255)
	constraint FK_CTDanhSach_CauHoi primary key(IDKythi,Khoikythi,IDMade,Khoidethi,IDHocsinh,Lop,Khoi,IDCauhoi,Khoicauhoi,IDDapan)
)
go

create table OnLuyen
(
	Solan int not null,
	IDHocsinh int not null,
	Lop int not null,
	Khoi int not null,
	Made int not null,
	Khoimade int not null,
	Ngaylam datetime not null,
	Diem real,
	Xong datetime,
	constraint FK_OnLuyen primary key (Solan,IDHocsinh,Lop,Khoi,Made,Khoimade)
)
go

create table CT_OnLuyen
(
	Solan int not null,
	IDHocsinh int not null,
	Lop int not null,
	Khoi int not null,
	Made int not null,
	Khoimade int not null,
	IDCauhoi int not null,
	IDKhoicauhoi int not null,
	IDDapan nchar(2) not null,
	Traloi bit null,
	Motacauhoi nvarchar(255),
	Motadapan nvarchar(255),


	constraint FK_CT_OnLuyen primary key (Solan,IDHocsinh,Lop,Khoi,Made,Khoimade,IDCauhoi,IDKhoicauhoi,IDDapan)
)
go

alter table OnLuyen
add constraint FK_HocSinh_Onluyen
foreign key(IDHocsinh,Lop,Khoi)
references HocSinh(ID,Lop,Khoi)
on update cascade
go

alter table OnLuyen
add constraint FK_Made_Onluyen
foreign key(Made,Khoimade)
references Made(ID,Khoi)
go

alter table CT_OnLuyen
add constraint FK_Onluyen_CTOnluyen
foreign key(Solan,IDHocsinh,Lop,Khoi,Made,Khoimade)
references OnLuyen(Solan,IDHocsinh,Lop,Khoi,Made,Khoimade)
on delete cascade
go

alter table CT_OnLuyen
add constraint FK_CTCauhoi_CTOnluyen
foreign key(IDCauhoi,IDKhoicauhoi,IDDapan)
references CT_Cauhoi(IDCauhoi,Khoi,IDDapan)
go

alter table HocSinh
add constraint KF_Nguoidung_HocSinh
foreign key(ID)
references NguoiDung(ID)
on update cascade
go

alter table GiaoVien
add constraint FK_Nguoidung_GiaoVien
foreign key(ID)
references NguoiDung(ID)
on update cascade
go

alter table QuanTri
add constraint FK_Nguoidung_QuanTri
foreign key(ID)
references NguoiDung(ID)
on update cascade
go

alter table CT_CauHoi
add constraint FK_CauHoi_CTCauHoi
foreign key(IDCauHoi,Khoi)
references CauHoi(ID,Khoi)
on update cascade
go


alter table CauHoi
add constraint FK_GiaoVien_CauHoi
foreign key(IDNguoitao)
references NguoiDung(ID)
on delete no action
go

alter table MaDe
add constraint FK_MaDe_GiaoVien
foreign key(IDNguoitao)
references GiaoVien(ID)
on delete no action

alter table CT_MaDe
add constraint FK_MaDe_CTMade
foreign key(IDMade,Khoimade)
references MaDe(ID,Khoi)
go

alter table CT_MaDe
add constraint FK_CTCauhoi_CTMade
foreign key(IDCauhoi,Khoicauhoi,IDDapan)
references CT_CauHoi(IDCauhoi,Khoi,IDDapan)
on delete cascade
go

alter table Kythi
add constraint FK_GiaoVien_KyThi
foreign key(IDNguoitao)
references GiaoVien(ID)
on update cascade
go

alter table CT_KyThi
add constraint FK_Kythi_CTKythi
foreign key(IDKythi,Khoikythi)
references KyThi(ID,Khoi)
on delete cascade
go

alter table CT_KyThi
add constraint FK_MaDe_CTKythi
foreign key(IDMade,Khoidethi)
references MaDe(ID,Khoi)
go

alter table CT_ThamGia
add constraint FK_CTKythi_CTThamgia
foreign key(IDKythi,Khoikythi,IDMade,Khoidethi)
references CT_Kythi(IDKythi,Khoikythi,IDMade,Khoidethi)
on update cascade
go

alter table CT_Thamgia
add constraint FK_HocSinh_CTThamgia
foreign key(IDHocsinh,Lop,Khoi)
references HocSinh(ID,Lop,Khoi)
on update cascade

go

alter table CT_KetQua
add constraint FK_CTKythi_CTKetqua
foreign key(IDKythi,Khoikythi,IDMade,Khoidethi,IDHocsinh,Lop,Khoi)
references CT_Thamgia(IDKythi,Khoikythi,IDMade,Khoidethi,IDHocsinh,Lop,Khoi)
on delete cascade
go

alter table CT_KetQua
add constraint FK_CTKythi_CTCauhoi
foreign key(IDCauhoi,Khoicauhoi,IDDapan)
references CT_Cauhoi(IDCauhoi,Khoi,IDDapan)
go

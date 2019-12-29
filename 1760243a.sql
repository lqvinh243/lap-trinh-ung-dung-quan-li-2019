create database DB
go

use DB
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






insert into NguoiDung(CMND,Loainguoidung,TaiKhoan,Matkhau) values(1,1,'a',1),(2,2,'b',1),(3,3,'c',1),(4,1,'d',1),(5,1,'e',1)
go

--select * From NguoiDung
--go

insert into HocSinh(ID,Lop,Khoi,Hoten,Ngaysinh) values(1,1,12,N'Gà','1999/10/12'),(4,2,12,N'Chó','1999/1/1'),(5,1,11,N'Mèo','2000/1/2')
go

--select * from HocSinh
--go

insert into QuanTri(ID) values(3)
--go

--select * from QuanTri
--go

insert into GiaoVien(ID) values(2)
go

--select * from GiaoVien
--go

/*insert into CauHoi values(1,12,N'Con chó có mấy chân',1,2),
						  (2,12,N'Con mèo kêu như thế nào',1,2),
						  (1,11,N'Gà thường gáy lúc mấy giờ?',1,2)
						  go
insert into CauHoi values(3,12,N'Chọn số liệu thích hợp để điền vào chỗ trống trong câu sau : Thực vật trên Trái Đất hiện có khoảng trên … loài',1,2),
						  (4,12,N'Cây nào dưới đây thường mọc hoang ở vùng trung du ?',1,2),
						  (5,12,N'Nơi nào dưới đây có hệ thực vật phong phú nhất ?',1,2),
						  (6,12,N'Những cây sống trôi nổi trên mặt nước thường có đặc điểm nào dưới đây ?',1,2),
						  (7,12,N'Đâu không phải là một trong những đặc điểm chung của thực vật ?',1,2),
						  (8,12,N'Khi chạm tay vào lá cây nào dưới đây, chúng sẽ từ từ khép lại  ?',1,2),
						  (9,12,N'Nhóm nào dưới đây gồm những cây thích nghi với môi trường khô nóng ở sa mạc ?',1,2),
						  (10,12,N'Cây nào dưới đây là cây gỗ sống lâu năm ?',1,2),
						  (11,12,N'Cây nào dưới đây không được xếp vào nhóm thực vật có hoa ?',1,2),
						  (12,12,N'Cây nào dưới đây có hạt nhưng không có quả ?',1,2),
						  (13,12,N'Nhóm các cơ quan sinh sản của thực vật không bao gồm thành phần nào dưới đây ?',1,2),
						  (14,12,N'Hạt là cơ quan sinh sản được tìm thấy ở loài thực vật nào dưới đây ?',1,2),
						  (15,12,N'Cây nào dưới đây có vòng đời kết thúc trong vòng một năm ?',1,2),
						  (16,12,N'Cơ quan nào dưới đây chỉ có ở thực vật có hoa ?',1,2),
						  (17,12,N'Các cây lương thực thường là?',1,2),
						  (18,12,N'Các cây : lúa, ngô, đậu, lạc từ khi nảy mầm đến khi chết đi chỉ kéo dài trong?',1,2),
						  (19,12,N'Nhóm nào dưới đây gồm những thực vật không có hoa ?',1,2),
						  (20,12,N'Vật nào dưới đây là vật sống ?',1,2),
						  (21,12,N'Kính lúp có khả năng phóng to ảnh của vật bao nhiêu lần ?',1,2),
						  (22,12,N'Kính hiển vi điện tử có khả năng phóng to ảnh của vật từ',1,2),
						  (23,12,N'Trong cấu tạo của kính hiển vi, bộ phận nào nằm ở trên cùng ?',1,2),
						  (24,12,N'Khi quan sát vật mẫu, tiêu bản được đặt lên bộ phận nào của kính hiển vi ?',1,2),
						  (25,12,N'Trong các loại tế bào dưới đây, tế bào nào dài nhất ?',1,2),
						  (26,12,N'Ở tế bào thực vật, bộ phận nào là ranh giới trung gian giữa vách tế bào và chất tế bào ?',1,2),
						  (27,12,N'Ai là người đầu tiên phát hiện ra sự tồn tại của tế bào ?',1,2),
						  (28,12,N'Lông hút ở rễ là một bộ phận của?',1,2),
						  (29,12,N'Khi nói về sự sắp xếp mạch rây và mạch gỗ tại miền hút của rễ, phát biểu nào dưới đây là đúng ?',1,2),
						  (30,12,N'Các tế bào biểu bì ở miền hút của rễ được sắp xếp thành mấy lớp ?',1,2),
						  (31,12,N'Phần sặc sỡ nhất của các loài hoa thụ phấn nhờ sâu bọ có tên gọi là gì ?',1,2),
						  (32,12,N'Nhận định nào sau đây không đúng khi nói về cấu trúc của virut?',1,2),
						  (33,12,N'Hệ gen của virut là?',1,2),
						  (34,12,N'Capsome là',1,2),
						  (35,12,N'Vỏ ngoài của virut là',1,2),
						  (36,12,N' Điều quan trọng nhất khiến virut chỉ là dạng sống kí sinh nội bào bắt buộc?',1,2),
						  (37,12,N'Điều nào sau đây là đúng về cấu trúc sống của virut?',1,2),
						  (38,12,N'Điều nào sau đây là sai về virut?',1,2),
						  (39,12,N'Phago ở E. coli là virut',1,2),
						  (40,12,N' Các đơn vị protein liên kết với nhau tạo nên',1,2),
						  (2,11,N'Nguyên tố vi lượng trong cơ thể sống không có đặc điểm nào sau đây?',1,2),
						  (3,11,N'Bệnh nào sau đây liên quan đến sự thiếu nguyên tố vi lượng?',1,2),
						  (4,11,N'Liên kết hóa học giữa các nguyên tử trong phân tử nước là',1,2),
						  (5,11,N'Nhận định nào sau đây không đúng về các nguyên tố chủ yếu của sự sống (C, H, O, N)?',1,2),
						  (6,11,N'Tính phân cực của nước là do',1,2),
						  (7,11,N'Đặc tính nào sau đây của phân tử nước quy định các đặc tính còn lại?',1,2),
						  (8,11,N'Chất nào sau đây chiếm khối lượng chủ yếu của tế bào?',1,2),
						  (9,11,N'Câu nào sau đây không đúng với vai trò của nước trong tế bào?',1,2),
						  (10,11,N'Nước chiếm khoảng bao nhiêu % khối lượng cơ thể người?',1,2),
						  (11,11,N'Các nhà khoa học khi tìm kiếm sự sống trên các hành tinh khác đều tìm kiếm sự có mặt của nước vì lý do nào sau đây',1,2),
						  (12,11,N'Iôt là nguyên tố vi lượng tham gia vào thành phần hoocmon của',1,2),
						  (13,11,N'Để bảo quản rau quả chúng ta không nên làm điều gì?',1,2),
						  (14,11,N'Các nucleic trên một mạch đơn của phần tử ADN liên kết với nhau bằng:',1,2),
						  (15,11,N'Axit nucleic cấu tọa theo nguyên tắc nào sau đây?',1,2),
						  (16,11,N'Liên kết hóa học đảm bảo cấu trúc của từng đơn phân nucleotit trong phân tử ADN là',1,2),
						  (17,11,N'Yếu tố quan trọng nhất tạo nên tính đặc trưng của phân tử ADN là',1,2),
						  (18,11,N' ADN có chức năng',1,2),
						  (19,11,N'Liên kết hidro trong phân tử ADN không có đặc điểm nào sau đây?',1,2),
						  (20,11,N'Đơn phân của ADN và ARN giống nhau ở',1,2),
						  (21,11,N'Bệnh truyền nhiễm là',1,2),
						  (22,11,N'Miễn dịch không đặc hiệu có đặc điểm nào sau đây?',1,2),
						  (23,11,N'Miễn dịch đặc hiệu',1,2),
						  (24,11,N'Điều nào sau đây là đặc điểm riêng của miễn dịch thể dịch?',1,2),
						  (25,11,N'Vi sinh vật có thể lây bệnh theo con đường nào sau đây?',1,2),
						  (26,11,N'Hình thức dinh dưỡng của trùng biến hình là',1,2),
						  (27,11,N'Trùng biến hình di chuyển được nhờ',1,2),
						  (28,11,N'Trùng biến hình di chuyển như thế nào?',1,2),
						  (29,11,N'Tiêu hóa thức ăn ở trùng giày nhờ',1,2),
						  (30,11,N'Vỏ trai cấu tạo gồm mấy lớp',1,2),
						  (31,11,N'Cơ quan nào đóng vai trò đóng, mở vỏ trai',1,2),
						  (32,11,N'Mài mặt ngoài vỏ trai ta thấy có mùi khét là do… bị cháy khét',1,2),
						  (33,11,N'Trai tự vệ nhờ',1,2),
						  (34,11,N'Trai lấy mồi ăn bằng cách',1,2),
						  (35,11,N'Trai lọc nước',1,2),
						  (36,11,N'Trai di chuyển được là nhờ',1,2),
						  (37,11,N'Ấu trùng trai thường bám vào mang và da cá để',1,2),
						  (38,11,N'Ngọc trai được tạo thành ở',1,2),
						  (39,11,N'Cây nào dưới đây có cánh hoa màu tím ?',1,2),
						  (40,11,N'Chức năng chủ yếu của bao hoa là gì ?',1,2)

select * from CauHoi
go

--insert into DapAn values(1,N'Gâu gâu'),(2,N'Bốn'),(3,N'Hai'),
--						 (4,N'Meo~'),(5,N'Ò ó o'),(6,N'6.PM'),
--						 (7,N'Kẹc kẹc'),(8,N'Năm'),(9,N'Không có chân nào'),
--						 (10,N'10.PM'),(11,N'Gà không gáy'),(12,N'5.AM'),
--						 (13,N'Gừ gừ'),(14,N'Ùm bò'),(15,N'12.AM'),(16,N'12.PM'),
--						 (17,N'Một')
--go

--select * from DapAn
--go

insert into CT_CauHoi values  (2,	12,	'A',N'Gâu gâu',1),
								(2,	12,	'B',N'Meo~',	0),
								(2,	12,	'C',N'Kẹc kẹc',	0),
								(2,	12,	'D',N'Ùm bò',	0),
								(2,	12,	'E',N'Gừ gừ',	0),
								(1,	12,	'A',N'Bốn',	1),
								(1,	12,	'B',N'Không có chân nào',	0),
								(1,	12,	'C',N'Một',	0),
								(1,	12,	'D',N'Năm',	0),
								(1,	12, 'E',N'Hai',	0),
								(1,	11,	'A',N'12.AM',	0),
								(1,	11,	'B',N'12.PM',	0),
								(1,	11,	'C',N'6.PM',	1),
								(1, 11,	'D',N'10.PM',	1),
								(1,	11,	'E',N'6.PM',	0)
go
insert into CT_CauHoi values  (3,	12,	'A',N'800 000',0),
								(3,	12,	'B',N'300 000',	0),
								(3,	12,	'C',N'1 000 000',	0),
								(3,	12,	'D',N'500 000',	0),
								(3,	12,	'E',N'300 000',	1),
								(4,	12,	'A',N'Cây Sim',	1),
								(4,	12,	'B',N'Cây Quế',	0),
								(4,	12,	'C',N'Cây Xương Rồng',	0),
								(4,	12,	'D',N'Cây Lá Lốt',	0),
								(4,	12, 'E',N'Cây Cau',	0),
								(5,	12,	'A',N'Rừng lá kim phương Bắc',	0),
								(5,	12,	'B',N'Rừng lá rộng ôn đới',	0),
								(5,	12,	'C',N'Rừng mưa nhiệt đới',	1),
								(5, 12,	'D',N'Rừng ngập mặn ven biển',	0),
								(5,	12,	'E',N'Rừng rậm nhiệt đới',	0),
								(6,	12,	'A',N'Xuất hiện bọt xốp màu trắng',	1),
								(6,	12,	'B',N'Tua cuốn phát triển mạnh',	0),
								(6,	12,	'C',N'Lá tiêu giảm',	0),
								(6,	12,	'D',N'Rễ phát triển theo chiều sâu',	0),
								(6,	12,	'E',N'Thân to',	0),
								(7,	12,	'A',N'Tự tổng hợp được chất hữu cơ',	0),
								(7,	12,	'B',N' Chỉ sống ở môi trường trên cạn',	1),
								(7,	12,	'C',N'Phần lớn không có khả năng di chuyển',0),
								(7,	12,	'D',N'Phản ứng chậm với các kích thích bên ngoài',	0),
								(7,	12,	'E',N'Có thể di chuyển',	0),
								(8,	12,	'A',N'Cây vừng',	0),
								(8,	12,	'B',N'Cây hồ tiêu',	0),
								(8, 12,	'C',N'Cây khoai tây',	0),
								(8,	12,	'D',N'Cây xấu hổ',	1),
								(8,	12,	'E',N'Cây lan',	0),
								(9,	12,	'A',N'Sen, đậu ván, cà rốt.',	0),
								(9,	12,	'B',N'Rau muối, cà chua, dưa chuột.',	0),
								(9, 12,	'C',N'Xương rồng, lê gai, cỏ lạc đà.',	1),
								(9,	12,	'D',N'Mâm xôi, cà phê, đào.',	0),
								(9,	12,	'E',N'Hoa Hồng',	0),
								(10,12,	'A',N'Xà cừ ',	1),
								(10,12,	'B',N'Mướp đắng',	0),
								(10, 12,'C',N'Dưa gang',	0),
								(10,12,	'D',N'Lạc',	0),
								(10,12,	'E',N'Cỏ',	0),
								(11,	12,	'A',N'Cây dương xỉ',	1),
								(11,	12,	'B',N'Cây bèo tây',	0),
								(11, 12,	'C',N'Cây chuối',	0),
								(11,	12,	'D',N'Cây lúa',	0),
								(11,	12,	'E',N'Cây Sen',	1),
								(12,	12,	'A',N'Cây chuối',	0),
								(12,	12,	'B',N'Cây ngô',	0),
								(12, 12,	'C',N'Cây thông',	1),
								(12,	12,	'D',N'Cây mía',	0),
								(12,	12,	'E',N'Cây lá bỏng',	0),
								(13,	12,	'A',N'Hạt',	0),
								(13,	12,	'B',N'Hoa',	1),
								(13, 12,	'C',N'Quả',	0),
								(13,	12,	'D',N'Rễ',	1),
								(13,	12,	'E',N'Lá',	0),
								(14,	12,	'A',N'Rêu',	0),
								(14,	12,	'B',N'Thìa là',	1),
								(14, 12,	'C',N'Dương xỉ',	0),
								(14,	12,	'D',N'Rau bợ',	0),
								(14,	12,	'E',N'Chôm Chôm',	1),
								(15,	12,	'A',N'Cây cau',	0),
								(15,	12,	'B',N'Cây mít',	0),
								(15, 12,	'C',N'Cây ngô ',	1),
								(15,	12,	'D',N'Cây ổi',	0),
								(15,	12,	'E',N'Cây Đậu',	1),
								(16,	12,	'A',N'Quả',	1),
								(16,	12,	'B',N'Hạt',	0),
								(16, 12,	'C',N'Rễ',	0),
								(16,	12,	'D',N'Thân',	0),
								(16,	12,	'E',N'Lá',	0),
								(17,	12,	'A',N'cây lâu năm.',	0),
								(17,	12,	'B',N'cây một năm.',	1),
								(17, 12,	'C',N'thực vật hạt trần.',	0),
								(17,	12,	'D',N'thực vật không có hoa.',	0),
								(17,	12,	'E',N'thực vật có hoa.',	1),
								(18,	12,	'A',N'1 - 3 năm.',	0),
								(18,	12,	'B',N'1 - 2 tháng',	0),
								(18, 12,	'C',N'6 - 12 tháng.',	0),
								(18,	12,	'D',N'3 – 6 tháng.',	1),
								(18,	12,	'E',N'5 – 10 năm.',	0),
								(19,	12,	'A',N'Rêu, mã đề, mồng tơi, rau ngót.',	0),
								(19,	12,	'B',N'Lá lốt, kinh giới, húng quế, diếp cá',	0),
								(19, 12,	'C',N'Mía, tre, dương xỉ, địa tiền',	0),
								(19,	12,	'D',N'Hoàng đàn, thông, rau bợ, dương xỉ',	1),
								(19,	12,	'E',N'Sen,Lan,Hồng',	0),
								(20,	12,	'A',N'Cây chúc',	1),
								(20,	12,	'B',N'Cây chổi',	0),
								(20, 12,	'C',N'Cây kéo',	0),
								(20,	12,	'D',N'Cây vàng',	0),
								(20,	12,	'E',N'Cây Cảnh',	1),
								(21,	12,	'A',N'3 - 20 lần',	1),
								(21,	12,	'B',N'25 - 50 lần',	0),
								(21, 12,	'C',N'100 - 200 lần',	0),
								(21,	12,	'D',N'2 - 3 lần',	0),
								(21,	12,	'E',N'400 - 500 lần',	0),
								(22,	12,	'A',N'5 000 - 8 000 lần.',	0),
								(22,	12,	'B',N'40 - 3 000 lần.',	0),
								(22, 12,	'C',N'10 000 - 40 000 lần.',	1),
								(22,	12,	'D',N'100 - 500 lần.',	0),
								(22,	12,	'E',N'1000 - 2000 lần.',	0),
								(23,	12,	'A',N'Vật kính',	1),
								(23,	12,	'B',N'Gương phản chiếu ánh sáng',	0),
								(23, 12,	'C',N'Bàn kính',	0),
								(23,	12,	'D',N'Thị kính',	1),
								(23,	12,	'E',N'Thấu kính',	0),
								(24,	12,	'A',N'Vật kính',	0),
								(24,	12,	'B',N'Thị kính',	0),
								(24, 12,	'C',N'Bàn kính',	1),
								(24,	12,	'D',N'Chân kính',	0),
								(24,	12,	'E',N'Lăng kính',	0),
								(25,	12,	'A',N'Tế bào mô phân sinh ngọn',	0),
								(25,	12,	'B',N'Tế bào sợi gai',	1),
								(25, 12,	'C',N'Tế bào thịt quả cà chua',	0),
								(25,	12,	'D',N'Tế bào tép bưởi',	0),
								(25,	12,	'E',N'Tế bào ngò gai',	0),
								(26,	12,	'A',N'Không bào',	0),
								(26,	12,	'B',N'Nhân',	0),
								(26, 12,	'C',N'Màng sinh chất',	1),
								(26,	12,	'D',N'Lục lạp',	0),
								(26,	12,	'E',N'Diệp Lục',	0),
								(27,	12,	'A',N'Antonie Leeuwenhoek',	0),
								(27,	12,	'B',N'Gregor Mendel',	0),
								(27, 12,	'C',N'Charles Darwin',	0),
								(27,	12,	'D',N'Robert Hook',	1),
								(27,	12,	'E',N'MaDeLa',	0),
								(28,	12,	'A',N'tế bào thịt vỏ.',	0),
								(28,	12,	'B',N'tế bào biểu bì.',	1),
								(28, 12,	'C',N'tế bào kèm.',	0),
								(28,	12,	'D',N'quản bào.',	1),
								(28,	12,	'E',N'Thực bào',	0),
								(29,	12,	'A',N'Mạch rây bao bên ngoài, mạch gỗ nằm ở phía trong',	1),
								(29,	12,	'B',N'Mạch rây xếp một phía, mạch gỗ xếp ở phía đối diện',	1),
								(29, 12,	'C',N'Mạch rây và mạch gỗ xếp xen kẽ nhau',	0),
								(29,	12,	'D',N'Mạch gỗ bao bên ngoài, mạch rây nằm ở phía trong',	0),
								(29,	12,	'E',N'Tất cả các ý trên',	0),
								(30,	12,	'A',N'1 lớp',	0),
								(30,	12,	'B',N'2 lớp',	1),
								(30, 12,	'C',N'3 lớp',	0),
								(30,	12,	'D',N'4 lớp',	0),
								(30,	12,	'E',N'5 lớp',	0),
								(31,	12,	'A',N'Nhuỵ',	0),
								(31,	12,	'B',N'Nhị',	0),
								(31, 12,	'C',N'Tràng ',	1),
								(31,	12,	'D',N'Đài',	0),
								(31,	12,	'E',N'Cánh',	0),
								(32,	12,	'A',N'Virut đã có cấu trúc tế bào',	1),
								(32,	12,	'B',N'Virut chưa có cấu trúc tế bào',	0),
								(32, 12,	'C',N'Virut chỉ có vỏ là protein và lõi là axit nucleic',	0),
								(32,	12,	'D',N'Cả B và C',	0),
								(32,	12,	'E',N'Cả B và D',	0),
								(33,	12,	'A',N'ADN hoặc ARN',	1),
								(33,	12,	'B',N'ADN, ARN, protein',	0),
								(33, 12,	'C',N'ARN, protein',	0),
								(33,	12,	'D',N'Nucleocapsit',	0),
								(33,	12,	'E',N'A và B',	0),
								(34,	12,	'A',N'Vỏ capsit được cấu tạo từ các phân tử protein',	1),
								(34,	12,	'B',N'Các phân tử axit nucleic',	0),
								(34, 12,	'C',N'Vỏ bọc ngoài virut',	0),
								(34,	12,	'D',N'Nucleocapsit',	0),
								(34,	12,	'E',N'ADN',	0),
								(35,	12,	'A',N'Vỏ ngoài của virut là',	0),
								(35,	12,	'B',N'Các gai glicoprotein',	1),
								(35, 12,	'C',N'Lớp lipit kép và protein bọc bên ngoài vỏ capsit',	1),
								(35,	12,	'D',N'Nucleocapsit',	0),
								(35,	12,	'E',N'ARN',	0),
								(36,	12,	'A',N'Virut không có cấu trúc tế bào',	0),
								(36,	12,	'B',N'Virut có cấu tạo quá đơn gairn chỉ gồm axit nucleic và protein',	0),
								(36, 12,	'C',N'Virut chỉ có thể nhân lên trong tế bào của vật chủ',	1),
								(36,	12,	'D',N'Virut có thể có hoặc không có vỏ ngoài',	0),
								(36,	12,	'E',N'Virut có cấu trúc tế bào',	0),
								(37,	12,	'A',N'Trong tế bào chủ, virut hoạt động như một thể sống',	0),
								(37,	12,	'B',N'Ngoài tế bào chủ, virut như một thể vô sinh',	1),
								(37, 12,	'C',N'Virut là một dạng sinh vật đặc biệt, chúng luôn có biểu hiện của sự sống',	0),
								(37,	12,	'D',N'Cả A và B',	0),
								(37,	12,	'E',N'Cả C và D',	0),
								(38,	12,	'A',N'Chỉ trong tế bào chủ, virut mới hoạt động như một thể sống',	1),
								(38,	12,	'B',N'Hệ gen của virut chỉ chứa một trong hai loại axit nucleic: ADN, ARN',	0),
								(38, 12,	'C',N'Kích thước của virut vô cùng nhỏ, chỉ có thể thấy được dưới kính hiển vi điện tử',	0),
								(38,	12,	'D',N'Ở bên ngoài tế bào sinh vật, virut vẫn hoạt động mặc dù nó chỉ là phức hợp gồm axit nucleic và protein, chưa phải là virut',	0),
								(38,	12,	'E',N'A và B',	0),
								(39,	12,	'A',N'Kí sinh ở vi sinh vật',	1),
								(39,	12,	'B',N' Kí sinh ở vi sinh vật và người',	1),
								(39, 12,	'C',N'Kí sinh ở vi sinh vật, thực vật, động vật và người',	0),
								(39,	12,	'D',N'Kí sinh ở thực vật, động vật và người',	0),
								(39,	12,	'E',N'Kí sinh ở  người',	0),
								(40,	12,	'A',N'capsome',	1),
								(40,	12,	'B',N'vỏ ngoài',	1),
								(40, 12,	'C',N'glicoprotein',	0),
								(40,	12,	'D',N'nucleocapsit',	0),
								(40,	12,	'E',N'C và D',	0),
								(2,	11,	'A',N'Chiếm tỉ lệ nhỏ hơn 0,01% khối lượng chất sóng của cơ thể.',	0),
								(2,	11,	'B',N'Chỉ cần cho thực vật ở giai đoạn sinh trưởng.',	1),
								(2, 11,	'C',N'Tham gia vào cấu trúc bắt buộc của hệ enzim trong tế bào',	0),
								(2,	11,	'D',N'Là những nguyên tố có trong tự nhiên.',	0),
								(2,	11,	'E',N'A và B',	0),
								(3,	11,	'A',N'Bệnh bướu cổ',	1),
								(3,	11,	'B',N'Bệnh còi xương',	1),
								(3, 11,	'C',N'Bệnh cận thị',	0),
								(3,	11,	'D',N'Bệnh tự kỉ',	0),
								(3,	11,	'E',N'Bệnh Chậm phát triển',	0),
								(4,	11,	'A',N'Liên kết cộng hóa trị',	1),
								(4,	11,	'B',N'liên kết hidro',	0),
								(4, 11,	'C',N'liên kết ion',	0),
								(4,	11,	'D',N' liên kết photphodieste',	0),
								(4,	11,	'E',N'liên kết ion hóa ',	0),
								(5,	11,	'A',N'Là các nguyên tố phổ biến trong tự nhiên.',	0),
								(5,	11,	'B',N'Có tính chất lý, hóa phù hợp với các tổ chức sống.',	0),
								(5, 11,	'C',N'Có khả năng liên kết với nhau và với các nguyên tố khác tạo nên đa dạng các loại phân tử và đại phân tử.',	1),
								(5,	11,	'D',N' Hợp chất của các nguyên tố này luôn hòa tan trong nước.',	0),
								(5,	11,	'E',N'A và B',	0),
								(6,	11,	'A',N'đôi êlectron trong mối liên kết O – H bị kéo lệch về phía ôxi.',	0),
								(6,	11,	'B',N'đôi êlectron trong mối liên kết O – H bị kéo lệch về phía hidro.',	1),
								(6, 11,	'C',N'xu hướng các phân tử nước.',	0),
								(6,	11,	'D',N'khối lượng phân tử của ôxi lớn hơn khối lượng phân tử của hidro.',	1),
								(6,	11,	'E',N'liên kết ion hóa',	0),
								(7,	11,	'A',N'Tính liên kết',	0),
								(7,	11,	'B',N'Tính điều hòa nhiệt',	0),
								(7, 11,	'C',N'Tính phân cực',	1),
								(7,	11,	'D',N'Tính cách li',	0),
								(7,	11,	'E',N'Tính dẫn nhiệt',	0),
								(8,	11,	'A',N'Protein',	0),
								(8,	11,	'B',N'Lipit',	1),
								(8, 11,	'C',N'Nước ',	1),
								(8,	11,	'D',N'Cacbonhidrat',	0),
								(8,	11,	'E',N'Cabon',	0),
								(9,	11,	'A',N'Nước tham gia vào quá trình chuyển hóa vật chất.',	0),
								(9,	11,	'B',N'Nước là thành phần cấu trúc của tế bào.',	0),
								(9, 11,	'C',N'Nước cung cấp năng lượng cho tế bào hoạt động.',	1),
								(9,	11,	'D',N'Nước trong tế bào luôn được đổi mới.',	0),
								(9,	11,	'E',N'A và C',	0),
								(10,	11,	'A',N'30%',	0),
								(10,	11,	'B',N'40%',	0),
								(10, 11,	'C',N'50%',	0),
								(10,	11,	'D',N'60%',	0),
								(10,	11,	'E',N'70%',	1),
								(11,	11,	'A',N'Nước là thành phần chủ yếu tham gia vào cấu trúc tế bào.',	1),
								(11,	11,	'B',N'Nước là dung môi cho mọi phản ứng sinh hóa trong tế bào.',	0),
								(11, 11,	'C',N'Nước được cấu tạo từ các nguyên tố đa lượng.',	0),
								(11,	11,	'D',N' Nước đảm bảo cho tế bào và cơ thể có nhiệt độ ổn định.',	0),
								(11,	11,	'E',N'B và D',	0),
								(12,	11,	'A',N'Tuyến thượng thận',	0),
								(12,	11,	'B',N'Tuyến yên',	0),
								(12, 11,	'C',N'Tuyến tụy ',	0),
								(12,	11,	'D',N'Tuyến giáp',	1),
								(12,	11,	'E',N'Tuyến Trước',	0),
								(13,	11,	'A',N'Giữ rau quả trong ngăn đá của tủ lạnh',	1),
								(13,	11,	'B',N'Giữ rau quả trong ngăn mát của tủ lạnh',	0),
								(13, 11,	'C',N'Sấy khô rau quả',	0),
								(13,	11,	'D',N'Ngâm rau quả trong nước muối hoặc nước đường.',	0),
								(13,	11,	'E',N'Ngâm rau quả trong nước muối hoặc nước muối.',	1),
								(14,	11,	'A',N'Liên kết phốtphodiestep',	0),
								(14,	11,	'B',N'Liên kết hidro',	0),
								(14, 11,	'C',N'Liên kết glicozo',	0),
								(14,	11,	'D',N' Liên kết peptit',	0),
								(14,	11,	'E',N'A và C',	1),
								(15,	11,	'A',N'Nguyên tắc đa phân',	1),
								(15,	11,	'B',N'Nguyên tắc bán bảo tồn và nguyên tắc đa phân',	0),
								(15, 11,	'C',N'Nguyên tắc bổ sung',	0),
								(15,	11,	'D',N'Nguyên tắc bổ sung và nguyên tắc đa phân',	0),
								(15,	11,	'E',N'Nguyên tắc lược bỏ',	0),
								(16,	11,	'A',N'Liên kết glicozit và liên kết este',	1),
								(16,	11,	'B',N'Liên kết hidro và liên kết este',	0),
								(16, 11,	'C',N'Liên kết glicozit và liên kết hidro',	0),
								(16,	11,	'D',N'Liên kết đisunphua và liên kết hidro',	0),
								(16,	11,	'E',N'Liên kết liên kết hidro',	0),
								(17,	11,	'A',N'Số lượng các nucleotit trong phân tử ADN',	0),
								(17,	11,	'B',N'Thành phần các nucleotit trong phân tử ADN',	0),
								(17, 11,	'C',N'Trình tự sắp xếp các nucleotit trong phân tử ADN',	1),
								(17,	11,	'D',N'Cách liên kết giữa các nucleotit trong phân tử ADN',	0),
								(17,	11,	'E',N'A và D',	0),
								(18,	11,	'A',N'Dự trữ và cung cấp năng lượng cho tế bào',	0),
								(18,	11,	'B',N'Cấu trúc nên màng tế bào, các bào quan',	0),
								(18, 11,	'C',N'Tham gia và quá trình chuyển hóa vật chất trong tế bào',	0),
								(18,	11,	'D',N'Lưu trữ và truyền đạt thông tin di truyền',	1),
								(18,	11,	'E',N'Duy trì tế bào',	0),
								(19,	11,	'A',N'Năng lượng liên kết nhỏ',	0),
								(19,	11,	'B',N'Đảm bảo tính bền vững, linh động của ADN',	0),
								(19, 11,	'C',N'Tạo nên cấu trúc không gian của ADN',	0),
								(19,	11,	'D',N'Liên kết khó hình thành và phá hủy',	1),
								(19,	11,	'E',N'Năng lượng liên kết lớn',	0),
								(20,	11,	'A',N'Đường',	0),
								(20,	11,	'B',N'Nhóm phôtphat',	1),
								(20, 11,	'C',N'Cách liên kết giữa các nucleotit',	0),
								(20,	11,	'D',N'Cấu trúc không gian',	0),
								(20,	11,	'E',N'Sắt',	0),
								(21,	11,	'A',N' Là bệnh do cá thể này tạo nên cho cá thể khác',	0),
								(21,	11,	'B',N'Là bệnh lây lan từ cá thể này sang cá thể khác',	1),
								(21, 11,	'C',N'Là bệnh do vi sinh vật gây nên',	0),
								(21,	11,	'D',N'Cả A, B và C',	0),
								(21,	11,	'E',N'Cả B và C',	0),
								(22,	11,	'A',N'Có tính bẩm sinh',	1),
								(22,	11,	'B',N'Là miễn dịch học được',	0),
								(22, 11,	'C',N'Có tính tập nhiễm',	0),
								(22,	11,	'D',N'Có tính bẩm sinh',	0),
								(22,	11,	'E',N'Cả B và C',	0),
								(23,	11,	'A',N'Có tính bẩm sinh',	0),
								(23,	11,	'B',N'Có tính bẩm sinh hoặc tập nhiễm tùy từng loại',	1),
								(23, 11,	'C',N'Có tính tập nhiễm',	0),
								(23,	11,	'D',N'Không đòi hỏi có sự tiếp xúc trước với kháng nguyên',	0),
								(23,	11,	'E',N'Không tính tập nhiễm',	0),
								(24,	11,	'A',N'Đều là miễn dịch không đặc hiệu',	0),
								(24,	11,	'B',N'Có sự hình thành kháng nguyên',	0),
								(24, 11,	'C',N'Tế bào T độc tiết ra protein độc có tác dụng làm tan tế bào bị nhiễm virut',	0),
								(24,	11,	'D',N'Có sự hình thành kháng thể',	1),
								(24,	11,	'E',N'Không sự hình thành kháng thể',	0),
								(25,	11,	'A',N'Con đường hô hấp, con đường tiêu hóa, con đường thần kinh',	0),
								(25,	11,	'B',N'Con đường hô hấp, con đường tiêu hóa, con đường tình dục',	0),
								(25, 11,	'C',N'Con đường hô hấp, con đường tiêu hóa, con đường tình dục, qua da',	1),
								(25,	11,	'D',N'Con đường hô hấp, con đường tiêu hóa, con đường tình dục, con đường thần kinh qua da',	0),
								(25,	11,	'E',N'C và D',	0),
								(26,	11,	'A',N'Các lông bơi',	0),
								(26,	11,	'B',N'Roi dài',	0),
								(26, 11,	'C',N'Chân giả',	1),
								(26,	11,	'D',N'Không bào co bóp',	0),
								(26,	11,	'E',N'Các lông bơi',	0),
								(27,	11,	'A',N'Thẳng tiến',	1),
								(27,	11,	'B',N' Xoay tròn',	0),
								(27, 11,	'C',N'Vừa tiến vừa xoay',	0),
								(27,	11,	'D',N'Cách khác',	0),
								(27,	11,	'E',N'A và B',	0),
								(28,	11,	'A',N'Phân đôi',	1),
								(28,	11,	'B',N' Tiếp hợp',	0),
								(28, 11,	'C',N'Nảy chồi',	0),
								(28,	11,	'D',N'Phân đôi và tiếp hợp',	0),
								(28,	11,	'E',N'Giao phối',	0),
								(29,	11,	'A',N'Men tiêu hóa',	0),
								(29,	11,	'B',N'Dịch tiêu hóa',	0),
								(29, 11,	'C',N'Chất tế bào',	0),
								(29,	11,	'D',N'Enzim tiêu hóa',	1),
								(29,	11,	'E',N'A và B',	0),
								(30,	11,	'A',N'2 lớp là lớp đá vôi và lớp sừng',	0),
								(30,	11,	'B',N'2 lớp là lớp xà cừ và lớp đá vôi',	0),
								(30, 11,	'C',N'3 lớp3 lớp là lớp sừng, lớp biểu bì và lớp đá vôi',	0),
								(30,	11,	'D',N' 3 lớp là lớp sừng, lớp đá vôi và lớp xà cừ',	1),
								(30,	11,	'E',N' 4 lớp là lớp sừng, lớp đá vôi và lớp xà cừ',	0),
								(31,	11,	'A',N'Đầu vỏ',	0),
								(31,	11,	'B',N'Đỉnh vỏ',	0),
								(31, 11,	'C',N'Cơ khép vỏ (bản lề vỏ)',	1),
								(31,	11,	'D',N'Đuôi vỏ',	0),
								(31,	11,	'E',N'Vỏ',	0),
								(32,	11,	'A',N'Lớp xà cừ',	0),
								(32,	11,	'B',N'Lớp sừng',	1),
								(32, 11,	'C',N' Lớp đá vôi',	0),
								(32,	11,	'D',N' Mang',	0),
								(32,	11,	'E',N'B và C',	0),
								(33,	11,	'A',N'Di chuyển nhanh',	0),
								(33,	11,	'B',N'Ẩn nấp trong môi trường bùn',	0),
								(33, 11,	'C',N'Có lớp vỏ cứng',	0),
								(33,	11,	'D',N'Cả b và c đúng',	1),
								(33,	11,	'E',N'Tất cả đều đúng',	0),
								(34,	11,	'A',N'Dùng chân giả bắt lấy con mồi',	0),
								(34,	11,	'B',N'Lọc nước',	1),
								(34, 11,	'C',N'Kí sinh trong cơ thể vật chủ',	0),
								(34,	11,	'D',N'Tấn công làm tê liệt con mồi',	0),
								(34,	11,	'E',N'Ăn vi sinh vật',	0),
								(35,	11,	'A',N'10 lít một ngày đêm',	0),
								(35,	11,	'B',N'20 lít một ngày đêm',	0),
								(35, 11,	'C',N'30 lít một ngày đêm',	0),
								(35,	11,	'D',N'40 lít một ngày đêm',	1),
								(35,	11,	'E',N'50 lít một ngày đêm',	0),
								(36,	11,	'A',N'Chân trai thò ra thụt vào',	0),
								(36,	11,	'B',N' Động tác đóng mở vỏ trai',	1),
								(36, 11,	'C',N'Hình thành chân giả',	0),
								(36,	11,	'D',N' Cả a và b đúng',	0),
								(36,	11,	'E',N'Tất cả các ý trên',	0),
								(37,	11,	'A',N'Lấy thức ăn',	0),
								(37,	11,	'B',N'Lẩn trốn kẻ thù',	0),
								(37, 11,	'C',N'Phát tán nòi giống',	1),
								(37,	11,	'D',N'Kí sinh',	0),
								(37,	11,	'E',N'Tất cả các ý trên',	0),
								(38,	11,	'A',N'Lớp sừng',	0),
								(38,	11,	'B',N'Lớp xà cừ',	1),
								(38, 11,	'C',N'Thân',	0),
								(38,	11,	'D',N'Ống thoát',	0),
								(38,	11,	'E',N'B và C',	0),
								(39,	11,	'A',N'Cà pháo',	0),
								(39,	11,	'B',N'Sim',	0),
								(39, 11,	'C',N'Bằng lăng',	0),
								(39,	11,	'D',N'Tất cả các phương án đưa ra',	1),
								(39,	11,	'E',N'Ổi',	0),
								(40,	11,	'A',N'Sinh sản',	0),
								(40,	11,	'B',N'Tổng hợp chất hữu cơ đi nuôi cây',	1),
								(40, 11,	'C',N'Bảo vệ, che chở cho nhị và nhuỵ',	0),
								(40,	11,	'D',N'Dự trữ sắc tố cho cây',	0),
								(40,	11,	'E',N'Tất cả các ý trên',	0)			
select * from CT_CauHoi


select * from CT_KetQua
--go

insert into MaDe(ID,Khoi,IDNguoitao,Dokho) values(1,12,2,N'Khó'),(1,11,2,N'Dễ'),(2,12,2,N'Dễ')
go
insert into MaDe(ID,Khoi,IDNguoitao,Dokho) values(3,12,2,N'Trung bình'),(4,11,2,N'Rất khó'),(5,12,2,N'Trung bình')
go
insert into MaDe(ID,Khoi,IDNguoitao,Dokho) values(4,12,2,N'Trung bình')
--select * from MaDe
select * from CT_OnLuyen
delete from CT_OnLuyen
delete from OnLuyen
select *from OnLuyen
insert into CT_MaDe(IDMade,Khoimade,IDCauhoi,Khoicauhoi,IDDapan) values(1,12,1,12,'A'),
																			(1,12,1,12,'B'),
																			(1,12,1,12,'C'),
																			(1,12,1,12,'D'),
																			(1,12,1,12,'E'),
																			(1,12,2,12,'A'),
																			(1,12,2,12,'C'),
																			(1,12,2,12,'B'),
																			(1,12,2,12,'D'),
																			(1,12,2,12,'E'),
																			(1,11,1,11,'A'),
																			(1,11,1,11,'B'),
																			(1,11,1,11,'C'),
																			(1,11,1,11,'D'),
																			(1,11,1,11,'E')
																			go


select count(IDCauhoi) from CT_MaDe where IDMade = 4 and Khoimade = 12 group by IDCauhoi,Khoicauhoi
insert into CT_MaDe(IDMade,Khoimade,IDCauhoi,Khoicauhoi,IDDapan)
values (4,12,1,12,'A'),	(4,12,1,12,'B'),(4,12,1,12,'C'),(4,12,1,12,'D'),(4,12,1,12,'E'),
(4,12,2,12,'A'),	(4,12,2,12,'B'),(4,12,2,12,'C'),(4,12,2,12,'D'),(4,12,2,12,'E'),
(4,12,3,12,'A'),	(4,12,3,12,'B'),(4,12,3,12,'C'),(4,12,3,12,'D'),(4,12,3,12,'E'),
(4,12,4,12,'A'),	(4,12,4,12,'B'),(4,12,4,12,'C'),(4,12,4,12,'D'),(4,12,4,12,'E'),
(4,12,5,12,'A'),	(4,12,5,12,'B'),(4,12,5,12,'C'),(4,12,5,12,'D'),(4,12,5,12,'E'),
(4,12,6,12,'A'),	(4,12,6,12,'B'),(4,12,6,12,'C'),(4,12,6,12,'D'),(4,12,6,12,'E'),
(4,12,7,12,'A'),	(4,12,7,12,'B'),(4,12,7,12,'C'),(4,12,7,12,'D'),(4,12,7,12,'E'),
(4,12,8,12,'A'),	(4,12,8,12,'B'),(4,12,8,12,'C'),(4,12,8,12,'D'),(4,12,8,12,'E'),
(4,12,9,12,'A'),	(4,12,9,12,'B'),(4,12,9,12,'C'),(4,12,9,12,'D'),(4,12,9,12,'E'),
(4,12,10,12,'A'),	(4,12,10,12,'B'),(4,12,10,12,'C'),(4,12,10,12,'D'),(4,12,10,12,'E'),
(4,12,11,12,'A'),	(4,12,11,12,'B'),(4,12,11,12,'C'),(4,12,11,12,'D'),(4,12,11,12,'E'),
(4,12,12,12,'A'),	(4,12,12,12,'B'),(4,12,12,12,'C'),(4,12,12,12,'D'),(4,12,12,12,'E'),
(4,12,13,12,'A'),	(4,12,13,12,'B'),(4,12,13,12,'C'),(4,12,13,12,'D'),(4,12,13,12,'E'),
(4,12,14,12,'A'),	(4,12,14,12,'B'),(4,12,14,12,'C'),(4,12,14,12,'D'),(4,12,14,12,'E'),
(4,12,15,12,'A'),	(4,12,15,12,'B'),(4,12,15,12,'C'),(4,12,15,12,'D'),(4,12,15,12,'E'),
(4,12,16,12,'A'),	(4,12,16,12,'B'),(4,12,16,12,'C'),(4,12,16,12,'D'),(4,12,16,12,'E'),
(4,12,17,12,'A'),	(4,12,17,12,'B'),(4,12,17,12,'C'),(4,12,17,12,'D'),(4,12,17,12,'E'),
(4,12,18,12,'A'),	(4,12,18,12,'B'),(4,12,18,12,'C'),(4,12,18,12,'D'),(4,12,18,12,'E'),
(4,12,19,12,'A'),	(4,12,19,12,'B'),(4,12,19,12,'C'),(4,12,19,12,'D'),(4,12,19,12,'E'),
(4,12,20,12,'A'),	(4,12,20,12,'B'),(4,12,20,12,'C'),(4,12,20,12,'D'),(4,12,20,12,'E'),
(4,12,21,12,'A'),	(4,12,21,12,'B'),(4,12,21,12,'C'),(4,12,21,12,'D'),(4,12,21,12,'E'),
(4,12,22,12,'A'),	(4,12,22,12,'B'),(4,12,22,12,'C'),(4,12,22,12,'D'),(4,12,22,12,'E'),
(4,12,23,12,'A'),	(4,12,23,12,'B'),(4,12,23,12,'C'),(4,12,23,12,'D'),(4,12,23,12,'E'),
(4,12,24,12,'A'),	(4,12,24,12,'B'),(4,12,24,12,'C'),(4,12,24,12,'D'),(4,12,24,12,'E'),
(4,12,25,12,'A'),	(4,12,25,12,'B'),(4,12,25,12,'C'),(4,12,25,12,'D'),(4,12,25,12,'E'),
(4,12,26,12,'A'),	(4,12,26,12,'B'),(4,12,26,12,'C'),(4,12,26,12,'D'),(4,12,26,12,'E'),
(4,12,27,12,'A'),	(4,12,27,12,'B'),(4,12,27,12,'C'),(4,12,27,12,'D'),(4,12,27,12,'E'),
(4,12,28,12,'A'),	(4,12,28,12,'B'),(4,12,28,12,'C'),(4,12,28,12,'D'),(4,12,28,12,'E'),
(4,12,29,12,'A'),	(4,12,29,12,'B'),(4,12,29,12,'C'),(4,12,29,12,'D'),(4,12,29,12,'E'),
(4,12,30,12,'A'),	(4,12,30,12,'B'),(4,12,30,12,'C'),(4,12,30,12,'D'),(4,12,30,12,'E'),
(4,12,31,12,'A'),	(4,12,31,12,'B'),(4,12,31,12,'C'),(4,12,31,12,'D'),(4,12,31,12,'E'),
(4,12,32,12,'A'),	(4,12,32,12,'B'),(4,12,32,12,'C'),(4,12,32,12,'D'),(4,12,32,12,'E'),
(4,12,33,12,'A'),	(4,12,33,12,'B'),(4,12,33,12,'C'),(4,12,33,12,'D'),(4,12,33,12,'E'),
(4,12,34,12,'A'),	(4,12,34,12,'B'),(4,12,34,12,'C'),(4,12,34,12,'D'),(4,12,34,12,'E'),
(4,12,35,12,'A'),	(4,12,35,12,'B'),(4,12,35,12,'C'),(4,12,35,12,'D'),(4,12,35,12,'E'),
(4,12,36,12,'A'),	(4,12,36,12,'B'),(4,12,36,12,'C'),(4,12,36,12,'D'),(4,12,36,12,'E'),
(4,12,37,12,'A'),	(4,12,37,12,'B'),(4,12,37,12,'C'),(4,12,37,12,'D'),(4,12,37,12,'E'),
(4,12,38,12,'A'),	(4,12,38,12,'B'),(4,12,38,12,'C'),(4,12,38,12,'D'),(4,12,38,12,'E'),
(4,12,39,12,'A'),	(4,12,39,12,'B'),(4,12,39,12,'C'),(4,12,39,12,'D'),(4,12,39,12,'E'),
(4,12,40,12,'A'),	(4,12,40,12,'B'),(4,12,40,12,'C'),(4,12,40,12,'D'),(4,12,40,12,'E')

													
--go

--select * from CT_MaDe
--go

insert into Kythi values(1,12,0,2,'2019/12/02'),(1,11,1,2,'2019/12/02')
--go
select  *from KyThi
insert into CT_KyThi values(1,12,1,12),(1,11,1,11)
--go
select *from KyThi
select * From CT_KyThi
--go
select * from CT_ThamGia
insert into CT_ThamGia (IDKythi,Khoikythi,IDMade,Khoidethi,IDHocsinh,Lop,Khoi) values   (1,	12,	1,	12,	1,	1,	12),
																					(1,	12,	1,	12,	4,	2,	12),
																			(1,	11,	1,	11,	5,	1,	11)
--go
select * from CT_KetQua
delete from CT_KetQua
--select * from CT_ThamGia
--go

--insert into CT_KetQua values	(1,	12,	1,	12,	1,	1,	12,	1,	2,	12,	1),
--								(1,	12,	1,	12,	1,	1,	12,	1,	3,	12,	0),
--								(1,	12,	1,	12,	1,	1,	12,	1,	6,	12,	0),
--								(1,	12,	1,	12,	1,	1,	12,	1,	9,	12,	0),
--								(1,	12,	1,	12,	1,	1,	12,	1,	8,	12,	0),
--								(1,	12,	1,	12,	1,	1,	12,	2,	1,	12,	0),
--								(1,	12,	1,	12,	1,	1,	12,	2,	13,	12,	1),
--								(1,	12,	1,	12,	1,	1,	12,	2,	14,	12,	0),
--								(1,	12,	1,	12,	1,	1,	12,	2,	7,	12,	0),
--								(1,	12,	1,	12,	1,	1,	12,	2,	4,	12,	1),
--								(1,	12,	1,	12,	4,	2,	12,	1,	2,	12,	1),
--								(1,	12,	1,	12,	4,	2,	12,	1,	3,	12,	0),
--								(1,	12,	1,	12,	4,	2,	12,	1,	6,	12,	1),
--								(1,	12,	1,	12,	4,	2,	12,	1,	9,	12,	0),
--								(1,	12,	1,	12,	4,	2,	12,	1,	8,	12,	0),
--								(1,	12,	1,	12,	4,	2,	12,	2,	1,	12,	0),
--								(1,	12,	1,	12,	4,	2,	12,	2,	13,	12,	1),
--								(1,	12,	1,	12,	4,	2,	12,	2,	14, 12,	0),
--								(1,	12,	1,	12,	4,	2,	12,	2,	7,	12,	0),
--								(1,	12,	1,	12,	4,	2,	12,	2,	4,	12,	1),
--								(1,	11,	1,	11,	5,	1,	11,	3,	11,	11,	0),
--								(1,	11,	1,	11,	5,	1,	11,	3,	10,	11,	0),
--								(1,	11,	1,	11, 5,	1,	11,	3,	12,	11,	1),
--								(1,	11,	1,	11,	5,	1,	11,	3,	6,	11,	1),
--								(1,	11,	1,	11,	5,	1,	11,	3,	15,	11,	0)
--go

--select * from CT_KetQua

--select * from HocSinh

--select * from CT_ThamGia ct where ct.CMND = 1

				 
*/
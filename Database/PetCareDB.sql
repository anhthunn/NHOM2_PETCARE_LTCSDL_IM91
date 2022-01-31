CREATE DATABASE PetCareDB
GO

USE PetCareDB
GO

--tblAccount 
--tblBill
--tblProducts 
--tblServices
--tblSuppliers
--tblPets

CREATE TABLE tblAccount 
(
     username nchar(20) PRIMARY KEY, -- Tên đăng nhập không được trùng
     password nchar (20) NOT NULL, -- Mật khẩu
	 fullname nvarchar(50) NOT NULL DEFAULT ('None'), --Tên người sở hữu tài khoản
	 type int NOT NULL DEFAULT (0) --Admin 1; Staff 0;
)

CREATE TABLE tblBill 
(
     billID int IDENTITY(1,1) PRIMARY KEY, ---ID tự sinh, tăng 1 cho mỗi đơn hàng
	 petID nchar(4) NOT NULL,
     petname nvarchar(20) NOT NULL,
	 customername nvarchar(50) NOT NULL,
	 product nvarchar(500) NULL,
	 service nvarchar(500) NULL,
	 total nchar(20) NOT NULL,
	 staff nchar(50) NOT NULL,
	 dayandtime nchar(100) NOT NULL
)

CREATE TABLE tblPets
(
	 petID nchar(4) PRIMARY KEY ,
	 petname nvarchar(20) NOT NULL,
	 customername nvarchar(50) NOT NULL, 
	 contact nchar(12) NOT NULL
)

CREATE TABLE tblProducts 
(
	 productID nchar(4) PRIMARY KEY,
	 productname nvarchar(100) NOT NULL, 
	 quantity int NOT NULL DEFAULT (0),
	 price int NOT NULL,
	 supplierID nchar(4) NOT NULL 
)

CREATE TABLE tblServices 
(
	 serviceID nchar(4) PRIMARY KEY,
	 servicename nvarchar(100) NOT NULL,
	 price int NOT NULL
)

CREATE TABLE tblSuppliers
(
	 supplierID nchar(4) PRIMARY KEY,
	 suppliername nvarchar(100) NOT NULL,
	 address nvarchar(250) NOT NULL,
	 contact nchar(12) NOT NULL
)

---------------THÊM RÀNG BUỘC KHÓA NGOẠI CHO CÁC BẢNG--------------------------------

ALTER TABLE [dbo].[tblProducts]  WITH CHECK ADD FOREIGN KEY([supplierID])
REFERENCES [dbo].[tblSuppliers] ([supplierID])
GO

--------------------------------------------------------------------------------------
-------------THÊM DỮ LIỆU CÓ SẴN CHO CÁC BẢNG-----------------------------------------

---BẢNG ACCOUNT
INSERT INTO tblAccount VALUES ('admin', 'admin', N'Nguyễn Ngọc Diệu', 1)
INSERT INTO tblAccount VALUES ('minhhuy', 'minhhuy', N'Phan Minh Huy', 0)
INSERT INTO tblAccount VALUES ('aimy123', 'aimy123', N'Lê Thị Ái My', 1)
INSERT INTO tblAccount VALUES ('staff', 'staff', N'Phạm Trần Thùy Dung', 0)

---BẢNG PETS (KHÁCH HÀNG CHƯA THANH TOÁN)
INSERT INTO tblPets VALUES ('6149', N'Susu', N'Nguyễn Quang Minh', '0377841200')
INSERT INTO tblPets VALUES ('0018', N'Đốm', N'Trần Thị Vy', '02773418991')
INSERT INTO tblPets VALUES ('2001', N'Layla', N'Lê Thị Diễm Hằng', '0866214033')
INSERT INTO tblPets VALUES ('1745', N'Ỉn', N'Phan Minh Trang', '0905418777')
INSERT INTO tblPets VALUES ('7312', N'Bé Bi', N'Trần Hy', '0860339569')
INSERT INTO tblPets VALUES ('0166', N'Cà Na', N'Trần Trung', '0377102058')
INSERT INTO tblPets VALUES ('5570', N'Bào Bào', N'Nguyễn Lê Mỹ An', '0903101734')
INSERT INTO tblPets VALUES ('0707', N'Mướp', N'Phạm Quốc Huy', '0862055313')

---BẢNG SUPPLIERS
INSERT INTO tblSuppliers VALUES ('7435', N'Đại lý sản phẩm sỉ thức ăn chó mèo Alanta', N'10 Đinh Tiên Hoàng, P3, Q5, TPHCM', '0868412370')
INSERT INTO tblSuppliers VALUES ('6320', N'Công ty Pinna chuyên phụ kiện thú cưng', N'200 Nguyễn Kiệm, P1, Q1, TPHCM', '0277541000')
INSERT INTO tblSuppliers VALUES ('1003', N'Cửa hàng tiện lợi cho PET', N'108 Nơ Trang Long, P10, Phú Nhuận, TPHCM', '0909145383')
INSERT INTO tblSuppliers VALUES ('2568', N'Siêu thị thú cưng Nation', N'5 Hoàng Văn Thụ, P3, Q3, TPHCM', '0166541177')

---BẢNG PRODUCTS
INSERT INTO tblProducts VALUES ('6235', N'Combo 3 chả cá sợi phô mai', 10, 155000, 7435)
INSERT INTO tblProducts VALUES ('1888', N'Thức ăn cho mèo vị hải sản 1kg', 50, 200500, 7435)
INSERT INTO tblProducts VALUES ('2050', N'Thức ăn cho chó ngũ vị siêu ngon 1kg', 23, 180500, 7435)
INSERT INTO tblProducts VALUES ('3930', N'Cỏ mèo gói 150gr', 11, 50000, 1003)
INSERT INTO tblProducts VALUES ('2239', N'Bánh cá nướng cho pet dinh dưỡng', 17, 75000, 7435)

INSERT INTO tblProducts VALUES ('1132', N'Vòng đeo tay cho mèo cưng', 15, 15000, 6320)
INSERT INTO tblProducts VALUES ('1871', N'Chuông đeo cho chó/mèo đủ màu', 5, 60300, 6320)
INSERT INTO tblProducts VALUES ('9351', N'Áo bò sữa đáng yêu cho pet', 3, 190200, 6320)
INSERT INTO tblProducts VALUES ('4405', N'Áo Pikachu vàng siêu xinh', 1, 195000, 6320)

INSERT INTO tblProducts VALUES ('7376', N'Sữa tắm mềm mịn lông cho chó/mèo', 9, 250000, 2568)
INSERT INTO tblProducts VALUES ('3974', N'Sữa tắm trị rận cho chó/mèo', 21, 120800, 2568)

---BẢNG DỊCH VỤ
INSERT INTO tblServices VALUES ('5810', N'Combo Tắm gội + Sấy khô', 500000)
INSERT INTO tblServices VALUES ('6511', N'Cắt móng cho pet', 50000)
INSERT INTO tblServices VALUES ('2111', N'Tỉa lông cho pet', 89000)
INSERT INTO tblServices VALUES ('4000', N'Nhuộm lông cho pet', 259000)
INSERT INTO tblServices VALUES ('3714', N'Duỗi lông cho pet', 230000)
INSERT INTO tblServices VALUES ('8347', N'Massage cho pet', 109000)







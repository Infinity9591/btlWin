USE master;
DROP DATABASE IF EXISTS StudentManagement;
GO
CREATE DATABASE StudentManagement;
GO
USE StudentManagement;
GO
DROP TABLE IF EXISTS [User]
GO
CREATE TABLE [User]
(
	ID int primary key,
	Username varchar(100),
	Password_hash varchar(100),
)
DROP TABLE IF EXISTS Class
GO
CREATE TABLE Class
(
	ID int primary key,
    ClassName nvarchar(50) not null,
	BranchName nvarchar(100) not null
)
GO
DROP TABLE IF EXISTS Student
GO
CREATE TABLE Student
( 
    ID int PRIMARY KEY,
    [Name] nvarchar(50) NOT NULL,
	Sex nvarchar(10) not null,
	Birth datetime not null,
    Phone nvarchar(50) NOT NULL,
    Email nvarchar(50) NOT NULL,
    [Address] nvarchar(50),
	GPA float NOT NULL,
    ClassID int foreign key references Class(ID)
)

INSERT INTO [User] VALUES (1, 'admin','quanly')

INSERT INTO Class VALUES (1,N'CNT62DH', N'Công Nghệ Thông Tin')
INSERT INTO Class VALUES (4,N'CNT61DH', N'Công Nghệ Thông Tin')
INSERT INTO Class VALUES (2,N'KPM62DH', N'Công Nghệ Phần Mềm')
INSERT INTO Class VALUES (3,N'TTM62DH', N'Truyền thông & Mạng máy tính')

INSERT INTO Student VALUES (90488, N'Phan Công Lý', N'Nam', '20031219', 123456789, 'abc@gmail.com', N'Số 3 Trần Nguyên Hãn', 9.9, 1)
INSERT INTO Student VALUES (90658, N'Nguyễn Thiên Tùng', N'Nam', '20030405', 123456789, 'def@gmail.com', N'Số 12 Hai Bà Trưng', 0.1, 3)
INSERT INTO Student VALUES (90123, N'Cao Trần Hưng', N'Nam', '20030911', 123456789, 'lmao@gmail.com', N'Số 75 Nguyễn Đức Cảnh', 5.4, 2)
INSERT INTO Student VALUES (90435, N'Nguyễn Thành Đạt', N'Nữ', '20030102', 987654321, 'aco@gmail.com', N'Số 1 Lê Hồng Phong', 0, 2)
INSERT INTO Student VALUES (90301, N'Đào Quốc Việt', N'Nam', '20030110', 287154321, 'heo@gmail.com', N'Số 112 Lý Thái Tổ', 4, 4)
INSERT INTO Student VALUES (91411, N'Trịnh Ngọc Hương', N'Nữ', '20030920', 412954901, 'bmv@gmail.com', N'Số 31 Hùng Vương', 1, 4)
INSERT INTO Student VALUES (92435, N'Phạm Vũ Hiến', N'Nam', '20030823', 871654321, 'cmv@gmail.com', N'Số 9 Lê Duy Đình', 8, 4)
INSERT INTO Student VALUES (92221, N'Nguyễn Ngọc Hiếu', N'Nam', '20030312', 912343219, 'hvn@gmail.com', N'Số 10 Lê Lai', 5, 3)
INSERT INTO Student VALUES (91412, N'Nguyễn Anh Tuấn', N'Nam', '20020712', 785754398, 'lmb@gmail.com', N'Số 66 Dư Hàng Kênh', 7, 2)
INSERT INTO Student VALUES (91489, N'Nguyễn Thùy Linh', N'Nữ', '20030303', 812354901, 'kmo@gmail.com', N'Số 20 Trại Chuối', 3, 2)
INSERT INTO Student VALUES (92411, N'Mai Thu Trang', N'Nữ', '20031113', 512354911, 'oop@gmail.com', N'Số 41 Đà Nẵng', 7.5, 1)
INSERT INTO Student VALUES (93644, N'Phạm Minh Hiền', N'Nữ', '20030128', 723418231, 'cpp@gmail.com', N'Số 128 Hoàng Diệu', 2, 1)
INSERT INTO Student VALUES (94365, N'Phạm Thành Công', N'Nam', '20030311', 287314329, 'ctd@gmail.com', N'Số 58 Định Thiên Hoàng', 7, 1)
INSERT INTO Student VALUES (97456, N'Đào Mai Trang', N'Nữ', '20030612', 371498221, 'gtn@gmail.com', N'Số 69 Nguyễn Thượng Huyền', 4.5, 2)
INSERT INTO Student VALUES (92523, N'Đinh Thu Thủy', N'Nữ', '20021112', 712341234, 'poa@gmail.com', N'Số 92 Phạm Phú Thứ', 2.5, 3)
INSERT INTO Student VALUES (91342, N'Bùi Huy Hoàng', N'Nam', '20020701', 835782123, 'mla@gmail.com', N'Số 131 Hàm Nghi', 6.5, 3)

drop view if EXISTS classview 
go
create view classview as
select ID as N'ID', ClassName as N'Tên Lớp' , BranchName as N'Tên Ngành'
from Class
go

select * from classview

DELETE FROM [User] WHERE (ID>1)

GO
DROP VIEW IF EXISTS studentview
GO
CREATE VIEW studentview AS
SELECT ROW_NUMBER() OVER (ORDER BY Student.ID) AS [STT], Student.ID as [Mã sinh viên], Student.[Name] as [Tên], Student.Sex as [Giới tính], Student.Birth as [Ngày sinh], 
		Student.Phone as [Số điện thoại], Email as [Email],  [Address] as [Địa chỉ], ClassName as [Lớp], BranchName as [Khoa], GPA as [Điểm trung bình]
FROM Student inner join Class on Student.ClassID = Class.ID

GO

select * from studentview

select coalesce ((select COUNT(*)
from class inner join student on Class.ID = Student.ClassID
where ClassName = 'CNT61DH'
group by ClassName), 0)

SELECT max(ID) FROM Class

select * from class
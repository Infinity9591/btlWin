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

INSERT INTO Student VALUES (90488, N'Phan Công Lý', N'Nam', '20031219', 123456789, 'abc@gmail.com', N'Trái đất', 9.9, 1)
INSERT INTO Student VALUES (90658, N'Nguyễn Thiên Tùng', N'Nam', '20220405', 123456789, 'def@gmail.com', N'Trái đất', 0.1, 3)
INSERT INTO Student VALUES (90123, N'Cao Trần Hưng', N'Nam', '20030919', 123456789, 'lmao@gmail.com', N'Trái đất', 5.4, 2)
INSERT INTO Student VALUES (90435, N'Nguyễn Thành Đạt', N'Nữ', '20220102', 987654321, 'aco@gmail.com', N'Trái đất', 0, 2)

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
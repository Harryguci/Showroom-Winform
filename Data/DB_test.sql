use master;
go
drop database SHOWROOM;

go
create database SHOWROOM;

go
use SHOWROOM;

go
create table Employee (
	EmployeeId NVARCHAR(10),
	FirstName NVARCHAR(100),
	LastName NVARCHAR(100),
	Phone NVARCHAR(15),
	Birth DATETIME
);

go

Insert Employee Values (
	N'e0001',
	N'Chu Quang',
	N'Huy',
	N'012345',
	CAST(N'2003-01-01T00:00:00.000' AS DateTime)
), (
	N'e0002',
	N'Nguyễn Trọng',
	N'Nghĩa',
	N'08888',
	CAST(N'2003-03-01T00:00:00.000' AS DateTime)
), (
	N'e0001',
	N'Nguyễn Đức',
	N'Hưng',
	N'09876',
	CAST(N'2003-05-05T00:00:00.000' AS DateTime)
), (
	N'e0001',
	N'Dương Quốc',
	N'Cường',
	N'07777',
	CAST(N'2003-11-11T00:00:00.000' AS DateTime)
);

go

use SHOWROOM;
go
select * from dbo.Employee;
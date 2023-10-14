use master;

go

Drop DATABASE ShowroomAuto;

Go

CREATE DATABASE ShowroomAuto
GO
use ShowroomAuto
go 


-- Tạo bảng Nhân viên
CREATE TABLE Employees (
    EmployeeId NVARCHAR(10) PRIMARY KEY,
    FirstName NVARCHAR(100),
    LastName NVARCHAR(100),
    DateBirth DATETIME,
    CCCD NVARCHAR(12),
    Position NVARCHAR(100),
    StartDate DATETIME,
    Salary INT,
    Email NVARCHAR(100),
    SaleId NVARCHAR(10)
);

-- Tạo bảng Khách hàng
CREATE TABLE Customers (
    ClientId NVARCHAR(10) PRIMARY KEY,
    FirstName NVARCHAR(100),
    LastName NVARCHAR(100),
    DateBirth DATETIME,
    CCCD NVARCHAR(12),
    Email NVARCHAR(100),
    Address NVARCHAR(200)
);

-- Tạo bảng Sản phẩm
CREATE TABLE Products (
    Name NVARCHAR(200),
    Serial NVARCHAR(100) PRIMARY KEY,
    Value INT,
    InEnterId NVARCHAR(10),
    InSaleId NVARCHAR(10),
    Status NVARCHAR(100)
);

-- Tạo bảng Hóa đơn nhập
CREATE TABLE PurchaseInvoices (
    InEnterId NVARCHAR(10) PRIMARY KEY,
    Source NVARCHAR(10),
    Price INT,
    Date DATETIME,
    Status NVARCHAR(100),
    EmployeeId NVARCHAR(10) 
);

-- Tạo bảng Hóa đơn bán
CREATE TABLE SalesInvoices (
    InSaleId NVARCHAR(10) PRIMARY KEY,
    ClientId NVARCHAR(10),
    Price INT,
    Date DATETIME,
    Status NVARCHAR(100),
    EmployeeId NVARCHAR(10) 
);

-- Tạo bảng Doanh số
CREATE TABLE SalesTargets (
    SaleId NVARCHAR(10) PRIMARY KEY,
    StartDate DATETIME,
    EndDate DATETIME,
    Total INT,
    Target INT,
    Status NVARCHAR(100),
    Rate INT
);
-- DROP TABLE SalesTargets
-- Tạo bảng Thiết bị
CREATE TABLE Devices (
    DeviceId NVARCHAR(10) PRIMARY KEY,
    Name NVARCHAR(200),
    Serial NVARCHAR(10),
    DateEntry DATETIME,
    Status NVARCHAR(100),
    Price INT
);
-- DROP TABLE Devices
-- Tạo bảng Lịch đăng ký lái thử
CREATE TABLE TestDrive (
    DriveId NVARCHAR(10) PRIMARY KEY,
    EmployeeId NVARCHAR(10),
    ClientId NVARCHAR(10),
    BookDate DATETIME,
    Note NVARCHAR(100),
    Status NVARCHAR(100)
);


INSERT INTO Employees (EmployeeId, FirstName, LastName, DateBirth, CCCD, Position, StartDate, Salary, Email, SaleId)
VALUES
    (N'E001', N'Nghĩa', N'Trọng Nguyễn', '1990-01-15', N'1234567890', N'Manager', '2020-05-10',150000, N'trongnghia@gmail.com', N'S001'),
    (N'E002', N'Tring', N'Ngọc', '1985-07-20', N'0987654321', N'Salesperson', '2019-11-25', 10000, N'ngoctrinh.com', N'S002'),
    (N'E003', N'Đăng', N'Hải', '1993-03-30', N'4567890123', N'Salesperson', '2021-02-15', 10000, N'haidang@gmail.com', N'S003'),
    (N'E004', N'Nguyên', N'Thảo', '1992-09-05', N'7654321098', N'Salesperson', '2018-08-02', 10000, N'thaonguyen@gmail.com', N'S004'),
    (N'E005', N'Huy', N'Quang', '1988-11-12', N'2345678901', N'Salesperson', '2020-06-18', 10000, N'quanghuy@gmail.com', N'S005'),
    (N'E006', N'Linh', N'Mai', '1994-04-25', N'8765432109', N'Salesperson', '2019-10-30', 10000, N'mailinh@gmail.com', N'S006'),
    (N'E007', N'Giang', N'Trường', '1987-02-10', N'3456789012', N'Salesperson', '2017-12-12', 10000, N'truonggiang@gmail.com', N'S007'),
    (N'E008', N'Anh', N'Quang', '1991-06-08', N'9876543210', N'Salesperson', '2022-03-22', 10000, N'quanganh@gmail.com', N'S008'),
    (N'E009', N'Tú', N'Minh', '1995-08-14', N'0123456789', N'Salesperson', '2019-09-14', 10000, N'minhtu@gmail.com', N'S009'),
    (N'E010', N'Linh', N'Ái', '1992-01-03', N'5432109876', N'Salesperson', '2018-07-05', 10000, N'linhai@gmail.com', N'S010');

-- DELETE  Employees

-- SELECT * from Employees

INSERT INTO Customers (ClientId, FirstName, LastName, DateBirth, CCCD, Email, Address)
VALUES
    (N'C001', N'Võ Thị', N'Hằng', '1980-05-12', N'1122334455', N'vo.thi.hang@example.com', N'123 Đường A, Thành phố A'),
    (N'C002', N'Đỗ Văn', N'Hòa', '1975-11-18', N'5544332211', N'do.van.hoa@example.com', N'456 Đường B, Thành phố B'),
    (N'C003', N'Lê Thanh', N'Dương', '1988-03-25', N'3344556677', N'le.thanh.duong@example.com', N'789 Đường C, Thành phố C'),
    (N'C004', N'Nguyễn Đức', N'Trí', '1982-07-09', N'7788990011', N'nguyen.duc.tri@example.com', N'101 Đường D, Thành phố D'),
    (N'C005', N'Linda', N'Davis', '1973-09-30', N'8899001122', N'linda.davis@example.com', N'222 Đường E, Thành phố E'),
    (N'C006', N'John', N'Miller', '1990-12-15', N'0011223344', N'john.miller@example.com', N'333 Đường F, Thành phố F'),
    (N'C007', N'Susan', N'Wilson', '1987-06-22', N'4455667788', N'susan.wilson@example.com', N'444 Đường G, Thành phố G'),
    (N'C008', N'Kevin', N'Anderson', '1979-02-28', N'6677889900', N'kevin.anderson@example.com', N'555 Đường H, Thành phố H'),
    (N'C009', N'Patricia', N'Thomas', '1984-04-10', N'2233445566', N'patricia.thomas@example.com', N'666 Đường I, Thành phố I'),
    (N'C010', N'Daniel', N'Harris', '1977-08-06', N'9900112233', N'daniel.harris@example.com', N'777 Đường J, Thành phố J');

INSERT INTO Products (Name, Serial, Value, InEnterId, InSaleId, Status)
VALUES
    (N'Sản phẩm 1', 'P001', 500, N'IE001', N'S001', N'Còn hàng'),
    (N'Sản phẩm 2', 'P002', 750, N'IE002', N'S002', N'Còn hàng'),
    (N'Sản phẩm 3', 'P003', 600, N'IE003', N'S003', N'Còn hàng'),
    (N'Sản phẩm 4', 'P004', 450, N'IE004', N'S004', N'Còn hàng'),
    (N'Sản phẩm 5', 'P005', 700, N'IE005', N'S005', N'Còn hàng'),
    (N'Sản phẩm 6', 'P006', 800, N'IE006', N'S006', N'Còn hàng'),
    (N'Sản phẩm 7', 'P007', 550, N'IE007', N'S007', N'Còn hàng'),
    (N'Sản phẩm 8', 'P008', 650, N'IE008', N'S008', N'Còn hàng'),
    (N'Sản phẩm 9', 'P009', 720, N'IE009', N'S009', N'Còn hàng'),
    (N'Sản phẩm 10', 'P010', 680, N'IE010', N'S010', N'Còn hàng');
-- DELETE Products
INSERT INTO PurchaseInvoices (InEnterId, Source, Price, Date, Status, EmployeeId)
VALUES
    (N'IE001', N'N001', 5000, '2023-01-15', N'Hoàn thành', N'E001'),
    (N'IE002', N'N002', 6000, '2023-01-20', N'Hoàn thành', N'E002'),
    (N'IE003', N'N003', 7500, '2023-02-01', N'Chưa xử lý', N'E003'),
    (N'IE004', N'N004', 4000, '2023-02-10', N'Hoàn thành', N'E001'),
    (N'IE005', N'N005', 5500, '2023-03-05', N'Hoàn thành', N'E001'),
    (N'IE006', N'N006', 4800, '2023-03-20', N'Hoàn thành', N'E002'),
    (N'IE007', N'N007', 6200, '2023-04-03', N'Chưa xử lý', N'E005'),
    (N'IE008', N'N008', 5100, '2023-04-15', N'Hoàn thành', N'E001'),
    (N'IE009', N'N009', 7300, '2023-05-01', N'Hoàn thành', N'E002'),
    (N'IE010', N'N010', 6000, '2023-05-12', N'Hoàn thành', N'E002');

-- DELETE PurchaseInvoices

INSERT INTO SalesInvoices (InSaleId, ClientId, Price, Date, Status, EmployeeId)
VALUES
    (N'S001', N'C001', 6000, '2023-01-16', N'Hoàn thành', N'E003'),
    (N'S002', N'C002', 7200, '2023-01-21', N'Hoàn thành', N'E002'),
    (N'S003', N'C003', 5500, '2023-02-02', N'Chưa xử lý', N'E003'),
    (N'S004', N'C004', 4500, '2023-02-11', N'Hoàn thành', N'E005'),
    (N'S005', N'C005', 6800, '2023-03-06', N'Hoàn thành', N'E002'),
    (N'S006', N'C006', 5900, '2023-03-21', N'Hoàn thành', N'E008'),
    (N'S007', N'C007', 6100, '2023-04-04', N'Chưa xử lý', N'E007'),
    (N'S008', N'C008', 5000, '2023-04-16', N'Hoàn thành', N'E002'),
    (N'S009', N'C009', 7400, '2023-05-02', N'Hoàn thành', N'E005'),
    (N'S010', N'C010', 6200, '2023-05-13', N'Hoàn thành', N'E010');
-- DELETE PurchaseInvoices

INSERT INTO SalesTargets (SaleId, StartDate, EndDate, Total, Target, Status, Rate)
VALUES
    (N'S001', '2023-11-01', '2023-11-30', 9500, 11500, N'Chưa xử lý', 4),
    (N'S002', '2023-12-01', '2023-12-31', 8000, 9500, N'Chưa xử lý', 4),
    (N'S003', '2024-01-01', '2024-01-31', 10500, 12500, N'Chưa xử lý', 4),
    (N'S004', '2024-02-01', '2024-02-29', 7200, 8500, N'Chưa xử lý', 4),
    (N'S005', '2024-03-01', '2024-03-31', 8900, 10500, N'Chưa xử lý', 4),
    (N'S006', '2024-04-01', '2024-04-30', 9400, 11500, N'Chưa xử lý', 4),
    (N'S007', '2024-05-01', '2024-05-31', 8100, 9500, N'Chưa xử lý', 4),
    (N'S008', '2024-06-01', '2024-06-30', 9700, 12000, N'Chưa xử lý', 4),
    (N'S009', '2024-07-01', '2024-07-31', 11000, 13000, N'Chưa xử lý', 4),
    (N'S010', '2024-08-01', '2024-08-31', 8500, 10000, N'Chưa xử lý', 4);

INSERT INTO Devices (DeviceId, Name, Serial, DateEntry, Status, Price)
VALUES
    (N'D001', N'Thiết bị 1', N'12345', '2023-01-05', N'Hoạt động', 200),
    (N'D002', N'Thiết bị 2', N'23456', '2023-01-10', N'Hoạt động', 220),
    (N'D003', N'Thiết bị 3', N'34567', '2023-01-15', N'Hoạt động', 250),
    (N'D004', N'Thiết bị 4', N'45678', '2023-01-20', N'Hoạt động', 180),
    (N'D005', N'Thiết bị 5', N'56789', '2023-01-25', N'Hoạt động', 210),
    (N'D006', N'Thiết bị 6', N'67890', '2023-01-30', N'Hoạt động', 230),
    (N'D007', N'Thiết bị 7', N'78901', '2023-02-05', N'Hoạt động', 240),
    (N'D008', N'Thiết bị 8', N'89012', '2023-02-10', N'Hoạt động', 190),
    (N'D009', N'Thiết bị 9', N'90123', '2023-02-15', N'Hoạt động', 260),
    (N'D010', N'Thiết bị 10', N'01234', '2023-02-20', N'Hoạt động', 270);

-- Chèn 10 giá trị vào bảng TestDrive
INSERT INTO TestDrive (DriveId, EmployeeId, ClientId, BookDate, Note, Status)
VALUES
    (N'T001', N'E001', N'C001', '2023-01-05', N'Lái thử sản phẩm 1', N'Đã hoàn thành'),
    (N'T002', N'E002', N'C002', '2023-01-10', N'Lái thử sản phẩm 2', N'Đã hoàn thành'),
    (N'T003', N'E003', N'C003', '2023-01-15', N'Lái thử sản phẩm 3', N'Chưa xử lý'),
    (N'T004', N'E004', N'C004', '2023-01-20', N'Lái thử sản phẩm 4', N'Đã hoàn thành'),
    (N'T005', N'E005', N'C005', '2023-01-25', N'Lái thử sản phẩm 5', N'Đã hoàn thành'),
    (N'T006', N'E006', N'C006', '2023-01-30', N'Lái thử sản phẩm 6', N'Chưa xử lý'),
    (N'T007', N'E007', N'C007', '2023-02-05', N'Lái thử sản phẩm 7', N'Đã hoàn thành'),
    (N'T008', N'E008', N'C008', '2023-02-10', N'Lái thử sản phẩm 8', N'Chưa xử lý'),
    (N'T009', N'E009', N'C009', '2023-02-15', N'Lái thử sản phẩm 9', N'Chưa xử lý'),
    (N'T010', N'E010', N'C010', '2023-02-20', N'Lái thử sản phẩm 10', N'Đã hoàn thành');

ALTER TABLE PurchaseInvoices
ADD CONSTRAINT FK_PurchaseInvoices_Employees FOREIGN KEY (EmployeeId) 
REFERENCES Employees(EmployeeId);

ALTER TABLE SalesInvoices
ADD CONSTRAINT FK_SalesInvoices_Employees FOREIGN KEY (EmployeeId) 
REFERENCES Employees(EmployeeId);

ALTER TABLE SalesInvoices
ADD CONSTRAINT FK_SalesInvoices_Customers FOREIGN KEY (ClientId) 
REFERENCES Customers(ClientId);

ALTER TABLE Products
ADD CONSTRAINT FK_Products_PurchaseInvoices FOREIGN KEY (InEnterId) 
REFERENCES PurchaseInvoices(InEnterId);

ALTER TABLE Products
ADD CONSTRAINT FK_Products_SalesInvoices FOREIGN KEY (InSaleId) 
REFERENCES SalesInvoices(InSaleId);

ALTER TABLE TestDrive
ADD CONSTRAINT FK_TestDrive_Employees FOREIGN KEY (EmployeeId) 
REFERENCES Employees(EmployeeId);

ALTER TABLE TestDrive
ADD CONSTRAINT FK_TestDrive_Customers FOREIGN KEY (ClientId) 
REFERENCES Customers(ClientId);

ALTER TABLE Employees
ADD CONSTRAINT FK_Employees_SalesTargets FOREIGN KEY (SaleId) 
REFERENCES SalesTargets(SaleId);
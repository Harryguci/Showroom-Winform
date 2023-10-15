

INSERT INTO Employees (EmployeeId, FirstName, LastName, DateBirth, CCCD, Position, StartDate, Salary, Email, SaleId)
VALUES (
    N'E011', N'Anh', 
    N'Phan Ngọc', 
    '2003-06-28',
    N'0999999', 
    N'Manager', 
    '2022-01-01',
    5500000, 
    N'admin@gmail.com', 
    NULL
)
GO
SELECT * FROM Employees;


Select Top 1 EmployeeId From Employees Order By EmployeeId DESC;


DELETE FROM Employees WHERE EmployeeId = N'e0012';
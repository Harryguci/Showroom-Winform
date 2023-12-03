    INSERT INTO Account (EmployeeId, Username, Password_foruser, Level_account, Deleted, CreateAt, DeleteAt, ClientId)
    VALUES 
        (N'E001', 'admin123', CONVERT(VARBINARY(500), '123456'),2, 0, GETDATE(), NULL, NULL),
        (N'E002', 'nhanvien1', CONVERT(VARBINARY(500), '123456'),2, 0, GETDATE(), NULL, NULL),
        (N'E003', 'nhanvien2', CONVERT(VARBINARY(500), '123456'),2, 0, GETDATE(), NULL, NULL)
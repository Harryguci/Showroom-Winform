INSERT INTO Account (EmployeeId, Username, Password_foruser,Level_account, Deleted, CreateAt, DeleteAt)
VALUES 
    (N'E001', 'john_doe2', CONVERT(VARBINARY(500), 'password1'),2, 0, GETDATE(), NULL),
    (N'E002', 'jane_smith', CONVERT(VARBINARY(500), 'password2'),1, 0, GETDATE(), NULL),
    (N'E003', 'bob_jones', CONVERT(VARBINARY(500), 'password3'),1, 0, GETDATE(), NULL),
    (N'E004', 'susan_wilson', CONVERT(VARBINARY(500), 'password4'),1, 0, GETDATE(), NULL),
    (N'E005', 'mike_adams', CONVERT(VARBINARY(500), 'password5'),1, 0, GETDATE(), NULL),
    (N'E006', 'lisa_miller', CONVERT(VARBINARY(500), 'password6'),1, 0, GETDATE(), NULL),
    (N'E007', 'david_brown', CONVERT(VARBINARY(500), 'password7'),1, 0, GETDATE(), NULL),
    (N'E008', 'emily_white', CONVERT(VARBINARY(500), 'password8'),1, 0, GETDATE(), NULL),
    (N'E009', 'steve_green', CONVERT(VARBINARY(500), 'password9'),1, 0, GETDATE(), NULL),
    (N'E010', 'jennifer_black', CONVERT(VARBINARY(500), 'password10'),1, 0, GETDATE(), NULL);
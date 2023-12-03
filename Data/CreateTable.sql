--- CREATE DATABASE ---
USE MASTER;
GO
CREATE DATABASE SHOWROOMAUTO;
GO
USE SHOWROOMAUTO;
GO
-- END: CREATE DATABASE ---

---------------------
--- ACCOUNT TABLE ---
---------------------
CREATE TABLE [dbo].[Account] (
    [Username]         VARCHAR (30)    NOT NULL,
    [Password_foruser] VARBINARY (500) NULL,
    [Level_account]    INT             NULL,
    [Deleted]          BIT             NULL,
    [CreateAt]         DATETIME        NULL,
    [DeleteAt]         DATETIME        NULL,
    [ClientId]         NVARCHAR (10)   NULL,
    [EmployeeId]       NVARCHAR (10)   NULL,
    PRIMARY KEY CLUSTERED ([Username] ASC),
    --CONSTRAINT [FK_Account_Customers] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Customers] ([ClientId]) ON DELETE CASCADE,
    --CONSTRAINT [FK_Account_Employees] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees] ([EmployeeId]) ON DELETE CASCADE
);


GO
CREATE   TRIGGER Hash_password on [dbo].[Account]
for INSERT,UPDATE
as 
BEGIN
    
    UPDATE Account
    SET Password_foruser = HASHBYTES('SHA2_512', i.Password_foruser)
    from Account as a 
    JOIN inserted as i on a.Username = i.Username
END


------------------------
---- CUSTOMERS TABLE ---
------------------------
CREATE TABLE [dbo].[Customers] (
    [ClientId]    NVARCHAR (10)  NOT NULL,
    [FirstName]   NVARCHAR (100) NULL,
    [LastName]    NVARCHAR (100) NULL,
    [DateBirth]   DATETIME       NULL,
    [PhoneNumber] NVARCHAR (20)  NULL,
    [Gender]      BIT            NULL,
    [CCCD]        NVARCHAR (20)  NULL,
    [Email]       NVARCHAR (100) NULL,
    [Address]     NVARCHAR (200) NULL,
    [Deleted]     BIT            NULL,
    PRIMARY KEY CLUSTERED ([ClientId] ASC)
);

----------------------
--- DEVICES TABLE ----
----------------------
CREATE TABLE [dbo].[Devices] (
    [DeviceId]  NVARCHAR (10)  NOT NULL,
    [Name]      NVARCHAR (200) NULL,
    [DateEntry] DATETIME       NULL,
    [Price]     INT            NULL,
    [Status]    NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([DeviceId] ASC)
);

----------------
-- EMPLOYEES ---
----------------
CREATE TABLE [dbo].[Employees] (
    [EmployeeId]  NVARCHAR (10)  NOT NULL,
    [FirstName]   NVARCHAR (100) NULL,
    [LastName]    NVARCHAR (100) NULL,
    [DateBirth]   DATETIME       NULL,
    [PhoneNumber] NVARCHAR (20)  NULL,
    [Gender]      BIT            NULL,
    [CCCD]        NVARCHAR (12)  NULL,
    [Position]    NVARCHAR (100) NULL,
    [StartDate]   DATETIME       NULL,
    [Salary]      INT            NULL,
    [Email]       NVARCHAR (100) NULL,
    [Deleted]     BIT            NULL,
    [Url_image]   NVARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC)
);

----------------------------
--- PRODUCT_IMAGES TABLE ---
----------------------------
CREATE TABLE [dbo].[Product_Images] (
    [id]        INT            IDENTITY (1, 1) NOT NULL,
    [Serial]    NVARCHAR (100) NULL,
    [Url_image] NVARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    -- CONSTRAINT [FK_ProductsImages_Products] FOREIGN KEY ([Serial]) REFERENCES [dbo].[Products] ([Serial]) ON DELETE CASCADE
);


----------------
--- PRODUCTS ---
----------------
CREATE TABLE [dbo].[Products] (
    [ProductName]   NVARCHAR (200) NULL,
    [Serial]        NVARCHAR (100) NOT NULL,
    [PurchasePrice] INT            NULL,
    [SalePrice]     INT            NULL,
    [Quantity]      INT            NULL,
    [Status]        NVARCHAR (100) NULL,
    [Deleted]       BIT            NULL,
    [Color]         NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Serial] ASC)
);

------------------------------
--- PURCHASEINVOICES TABLE ---
------------------------------
CREATE TABLE [dbo].[PurchaseInvoices] (
    [InEnterId]        NVARCHAR (10)  NOT NULL,
    [SourceId]         NVARCHAR (10)  NULL,
    [ProductId]        NVARCHAR (100) NULL,
    [Date]             DATETIME       NULL,
    [QuantityPurchase] INT            NULL,
    [Status]           NVARCHAR (100) NULL,
    [Deleted]          BIT            NULL,
    PRIMARY KEY CLUSTERED ([InEnterId] ASC),
    --CONSTRAINT [FK_PurchaseInvoices_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Serial]) ON DELETE CASCADE,
    --CONSTRAINT [FK_PurchaseInvoices_Source] FOREIGN KEY ([SourceId]) REFERENCES [dbo].[Source] ([SourceId]) ON DELETE CASCADE
);


GO
-- Tạo trigger sau khi INSERT hoặc UPDATE hóa đơn mua (PurchaseInvoices)
CREATE   TRIGGER UpdatePurchaseQuantity
ON PurchaseInvoices
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE p
    SET p.Quantity = p.Quantity + i.QuantityPurchase
    FROM inserted AS i
    INNER JOIN Products AS p ON i.ProductId = p.Serial;

    -- Tăng số lượng cho các bản ghi trong bảng deleted
    UPDATE p
    SET p.Quantity = p.Quantity - d.QuantityPurchase
    FROM deleted AS d
    INNER JOIN Products AS p ON d.ProductId = p.Serial;
END;
--- Tao 
GO
CREATE   TRIGGER Update_quantityafter_purchase
on PurchaseInvoices
for DELETE
as 
BEGIN
    UPDATE P
    set p.Quantity = p.Quantity - d.QuantityPurchase
    from deleted AS d join Products as p on d.ProductId = p.Serial
end 

---------------------
--- SALESINVOICES ---
---------------------
CREATE TABLE [dbo].[SalesInvoices] (
    [InSaleId]     NVARCHAR (10)  NOT NULL,
    [ClientId]     NVARCHAR (10)  NULL,
    [EmployeeId]   NVARCHAR (10)  NULL,
    [ProductId]    NVARCHAR (100) NULL,
    [Date]         DATETIME       NULL,
    [QuantitySale] INT            NULL,
    [Status]       NVARCHAR (100) NULL,
    [Deleted]      BIT            NULL,
    PRIMARY KEY CLUSTERED ([InSaleId] ASC),
    --CONSTRAINT [FK_SalesInvoices_Customers] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Customers] ([ClientId]) ON DELETE CASCADE,
    --CONSTRAINT [FK_SalesInvoices_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Serial]) ON DELETE CASCADE,
    --CONSTRAINT [FK_SalesInvoices_Employees] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees] ([EmployeeId]) ON DELETE CASCADE
);


GO

CREATE   TRIGGER Update_quantityafter_sale 
on SalesInvoices
for DELETE
as
BEGIN
    update p
    set p.Quantity = p.Quantity + d.QuantitySale
    FROM deleted as d join Products as p on d.ProductId = p.Serial
END

-------- cap nhat sau khi insert , update ----
GO
CREATE   TRIGGER Update_quantityafter_insertupdate 
on SalesInvoices
for INSERT,update
as 
BEGIN
    UPDATE p
    set p.Quantity = p.Quantity + d.QuantitySale
    from deleted as d join Products as p on d.ProductId = p.Serial

    UPDATE p
    set p.Quantity = p.Quantity -i.QuantitySale
    from inserted as i join Products as p on i.ProductId = p.Serial
END
GO
CREATE   TRIGGER KPI 
ON [dbo].[SalesInvoices]
FOR INSERT,UPDATE 
AS 
BEGIN
    UPDATE s
    set Total =Total + Cast(i.QuantitySale* p.SalePrice as INT) 
    FROM inserted as i join SalesTargets as s on i.EmployeeId = s.EmployeeId
    join Products as p on i.ProductId = p.Serial
    WHERE i.EmployeeId = s.EmployeeId
END 

--------------------
--- SALESTARGETS ---
--------------------
CREATE TABLE [dbo].[SalesTargets] (
    [SaleId]     NVARCHAR (10)  NOT NULL,
    [EmployeeId] NVARCHAR (10)  NULL,
    [StartDate]  DATETIME       NULL,
    [EndDate]    DATETIME       NULL,
    [Total]      INT            NULL,
    [Target]     INT            NULL,
    [Status]     NVARCHAR (100) NULL,
    [Reward]     FLOAT (53)     NULL,
    PRIMARY KEY CLUSTERED ([SaleId] ASC),
    CONSTRAINT [FK_Employee_SaleTarget] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees] ([EmployeeId]) ON DELETE CASCADE
);

--------------
--- SOURCE ---
--------------
CREATE TABLE [dbo].[Source] (
    [SourceId] NVARCHAR (10)  NOT NULL,
    [Name]     NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([SourceId] ASC)
);

-------------
--- TASKS ---
-------------
CREATE TABLE [dbo].[TASKS] (
    [ID]         NVARCHAR (10)  NOT NULL,
    [EMPLOYEEID] NVARCHAR (10)  NULL,
    [DATELINE]   DATETIME       NULL,
    [CONTENT]    NVARCHAR (500) NULL,
    [RESULT]     NVARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    -- CONSTRAINT [FK_Tasks_Employees] FOREIGN KEY ([EMPLOYEEID]) REFERENCES [dbo].[Employees] ([EmployeeId])
);

----------------
-- TESTDRIVE ---
----------------
CREATE TABLE [dbo].[TestDrive] (
    [DriveId]    NVARCHAR (10)  NOT NULL,
    [EmployeeId] NVARCHAR (10)  NULL,
    [ClientId]   NVARCHAR (10)  NULL,
    [BookDate]   DATETIME       NULL,
    [Note]       NVARCHAR (100) NULL,
    [Status]     NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([DriveId] ASC),
    -- CONSTRAINT [FK_TestDrive_Employees] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees] ([EmployeeId]) ON DELETE CASCADE ON UPDATE CASCADE
);
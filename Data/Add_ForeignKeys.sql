------------------------
-- ALTER FOREIGN KEYS --
------------------------
ALTER TABLE [dbo].[Account] ADD CONSTRAINT [FK_Account_Customers] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Customers] ([ClientId]) ON DELETE CASCADE;
ALTER TABLE [dbo].[Account] ADD CONSTRAINT [FK_Account_Employees] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees] ([EmployeeId]) ON DELETE CASCADE;
ALTER TABLE [dbo].[Product_Images] ADD CONSTRAINT [FK_ProductsImages_Products] FOREIGN KEY ([Serial]) REFERENCES [dbo].[Products] ([Serial]) ON DELETE CASCADE;
ALTER TABLE [dbo].[PurchaseInvoices] ADD CONSTRAINT [FK_PurchaseInvoices_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Serial]) ON DELETE CASCADE;
ALTER TABLE [dbo].[PurchaseInvoices] ADD CONSTRAINT [FK_PurchaseInvoices_Source] FOREIGN KEY ([SourceId]) REFERENCES [dbo].[Source] ([SourceId]) ON DELETE CASCADE;
ALTER TABLE [dbo].[SalesInvoices] ADD CONSTRAINT [FK_SalesInvoices_Customers] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Customers] ([ClientId]) ON DELETE CASCADE;
ALTER TABLE [dbo].[SalesInvoices] ADD CONSTRAINT [FK_SalesInvoices_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Serial]) ON DELETE CASCADE;
ALTER TABLE [dbo].[SalesInvoices] ADD CONSTRAINT [FK_SalesInvoices_Employees] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees] ([EmployeeId]) ON DELETE CASCADE
ALTER TABLE [dbo].[SalesTargets] ADD CONSTRAINT [FK_Employee_SaleTarget] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees] ([EmployeeId]) ON DELETE CASCADE;
ALTER TABLE [dbo].[TASKS] ADD CONSTRAINT [FK_Tasks_Employees] FOREIGN KEY ([EMPLOYEEID]) REFERENCES [dbo].[Employees] ([EmployeeId])
ALTER TABLE [dbo].[TestDrive] ADD CONSTRAINT [FK_TestDrive_Employees] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees] ([EmployeeId]) ON DELETE CASCADE ON UPDATE CASCADE

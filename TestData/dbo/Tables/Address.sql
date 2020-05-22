CREATE TABLE [dbo].[Address]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmployeeId] INT NOT NULL, 
    [Country] NVARCHAR(50) NULL,
    [Region] NVARCHAR(50) NULL,
    [City] NVARCHAR(50) NULL, 
    [StreetAddress] NVARCHAR(50) NULL, 
    [PostalCode] NVARCHAR(10) NULL, 
    CONSTRAINT [FK_Address_Employee] FOREIGN KEY ([EmployeeId]) REFERENCES [Employee]([Id]) 
)

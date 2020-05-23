CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [MiddleName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [DateOfBirth] DATE NOT NULL, 
    [Department] NVARCHAR(50) NULL, 
    [About] NTEXT NULL
)

CREATE PROCEDURE [dbo].[spAddresses_Insert]
    @EmployeeId INT,
    @Country NVARCHAR(50),
    @Region NVARCHAR(50),
    @City NVARCHAR(50),
    @StreetAddress NVARCHAR(50),
    @PostalCode NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.Address (EmployeeId, Country, Region, City, StreetAddress, PostalCode)
    VALUES (@EmployeeId, @Country, @Region, @City, @StreetAddress, @PostalCode);

    SELECT CAST(scope_identity() AS int)
END
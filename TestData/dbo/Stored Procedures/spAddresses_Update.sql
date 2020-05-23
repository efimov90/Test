CREATE PROCEDURE [dbo].[spAddresses_Update]
    @Id INT,
    @EmployeeId INT,
    @Country NVARCHAR(50),
    @Region NVARCHAR(50),
    @City NVARCHAR(50),
    @StreetAddress NVARCHAR(50),
    @PostalCode NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.Address 
    SET 
        EmployeeId = @EmployeeId,
        Country = @Country,
        Region = @Region,
        City = @City,
        StreetAddress = @StreetAddress,
        PostalCode = @PostalCode
    WHERE Id = @Id;

    SELECT CAST(scope_identity() AS int)
END
CREATE PROCEDURE [dbo].[spEmployees_Insert]
	@FirstName NVARCHAR(50), 
    @MiddleName NVARCHAR(50), 
    @LastName NVARCHAR(50), 
    @DateOfBirth DATE, 
    @Department NVARCHAR(50), 
    @About NTEXT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.Employee (FirstName, MiddleName, LastName, DateOfBirth, Department, About)
    VALUES (@FirstName, @MiddleName, @LastName, @DateOfBirth, @Department, @About);

    SELECT CAST(scope_identity() AS int)
END
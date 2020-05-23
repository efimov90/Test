﻿CREATE PROCEDURE [dbo].[spEmployees_Update]
    @Id INT,
	@FirstName NVARCHAR(50), 
    @MiddleName NVARCHAR(50), 
    @LastName NVARCHAR(50), 
    @DateOfBirth DATE, 
    @Department NVARCHAR(50), 
    @About NTEXT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.Employee 
    SET
        FirstName = @FirstName,
        MiddleName = @MiddleName,
        LastName = @LastName,
        DateOfBirth = @DateOfBirth,
        Department = @Department,
        About = @About
    WHERE Id = @Id;

    SELECT CAST(scope_identity() AS int)
END
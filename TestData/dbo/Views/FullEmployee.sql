CREATE VIEW [dbo].[FullEmployee]
	AS
	SELECT [e].[Id] AS EmployeeId,
		[e].[FirstName], [e].[MiddleName], [e].[LastName],
		[e].[DateOfBirth], [e].[Department], [e].[About],
		[a].[Id] AS AddressId, [a].[Country], [a].[Region],
		[a].[City], [a].[StreetAddress], [a].[PostalCode]
	FROM dbo.Employee e
	LEFT JOIN dbo.Address a ON e.Id = a.EmployeeId

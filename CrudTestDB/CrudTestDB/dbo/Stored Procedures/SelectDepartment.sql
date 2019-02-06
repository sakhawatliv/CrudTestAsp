CREATE PROCEDURE SelectDepartment @Name nvarchar(30) = NULL
AS
BEGIN
SELECT * FROM Department WHERE DepartmentName= @Name
END;
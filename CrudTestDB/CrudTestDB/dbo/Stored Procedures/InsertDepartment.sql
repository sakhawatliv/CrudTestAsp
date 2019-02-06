CREATE PROCEDURE InsertDepartment @Name nvarchar(30) = NULL, @Code nvarchar(10) = NULL
AS
BEGIN
INSERT INTO Department(DepartmentName,Code) VALUES(@Name,@Code)
END;
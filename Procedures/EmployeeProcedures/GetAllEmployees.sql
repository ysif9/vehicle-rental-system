-- GetAllEmployees procedure for Employee table
CREATE PROCEDURE GetAllEmployees
AS
BEGIN
    SELECT EmployeeID, Name, Role, Age, Salary, Enrollment_Date FROM Employee
END
GO

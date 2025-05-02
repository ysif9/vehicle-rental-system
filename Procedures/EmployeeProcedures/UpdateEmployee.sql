-- UpdateEmployee procedure for Employee table
CREATE PROCEDURE UpdateEmployee
    @EmployeeID INT,
    @Name VARCHAR(100),
    @Role VARCHAR(50),
    @Age INT,
    @Salary DECIMAL(10,2),
    @Enrollment_Date DATE
AS
BEGIN
    UPDATE Employee
    SET Name = @Name, Role = @Role, Age = @Age, Salary = @Salary, Enrollment_Date = @Enrollment_Date
    WHERE EmployeeID = @EmployeeID
END
GO

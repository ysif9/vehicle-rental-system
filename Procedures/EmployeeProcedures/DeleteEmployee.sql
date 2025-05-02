-- DeleteEmployee procedure for Employee table
CREATE PROCEDURE DeleteEmployee
    @EmployeeID INT
AS
BEGIN
    DELETE FROM Employee WHERE EmployeeID = @EmployeeID
END
GO

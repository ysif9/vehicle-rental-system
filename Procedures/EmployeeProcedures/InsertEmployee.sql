-- InsertEmployee procedure for Employee table
CREATE PROCEDURE InsertEmployee
    @Name VARCHAR(100),
    @Role VARCHAR(50),
    @Age INT,
    @Salary DECIMAL(10,2),
    @Enrollment_Date DATE
AS
BEGIN
    INSERT INTO Employee (Name, Role, Age, Salary, Enrollment_Date)
    VALUES (@Name, @Role, @Age, @Salary, @Enrollment_Date)
END
GO

CREATE PROCEDURE AssignEmployeeToGarage
    @EmployeeID INT,
    @GarageID INT
AS
BEGIN
INSERT INTO Employee_Works_For_Garage (EmployeeID, GarageID)
VALUES (@EmployeeID, @GarageID);
END;
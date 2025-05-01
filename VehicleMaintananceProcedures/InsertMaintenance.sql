CREATE PROCEDURE InsertMaintenance
    @VehicleID INT,
    @MaintenanceDate DATE,
    @Description VARCHAR(200),
    @Cost DECIMAL(10,2),
    @Status VARCHAR(50)
AS
BEGIN
    INSERT INTO Maintenance (VehicleID, Maintenance_Date, Description, Cost, Status)
    VALUES (@VehicleID, @MaintenanceDate, @Description, @Cost, @Status);

    SELECT SCOPE_IDENTITY(); -- return the new MaintenanceID
END; 
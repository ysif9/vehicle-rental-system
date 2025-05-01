CREATE PROCEDURE UpdateMaintenance
    @MaintenanceID INT,
    @VehicleID INT,
    @MaintenanceDate DATE,
    @Description VARCHAR(200),
    @Cost DECIMAL(10,2),
    @Status VARCHAR(50)
AS
BEGIN
    UPDATE Maintenance
    SET VehicleID = @VehicleID,
        Maintenance_Date = @MaintenanceDate,
        Description = @Description,
        Cost = @Cost,
        Status = @Status
    WHERE MaintenanceID = @MaintenanceID;
END; 
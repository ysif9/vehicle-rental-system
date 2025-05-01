CREATE PROCEDURE DeleteMaintenance
    @MaintenanceID INT
AS
BEGIN
    DELETE FROM Maintenance WHERE MaintenanceID = @MaintenanceID;
END; 
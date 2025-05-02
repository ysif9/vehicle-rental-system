CREATE PROCEDURE DeleteVehicleNeedsMaintenance
    @Maintenance_Number INT,
    @CarID              INT
AS
BEGIN
    DELETE FROM Vehicle_Needs_Maintenance
    WHERE Maintenance_Number = @Maintenance_Number AND CarID = @CarID;
END;
GO

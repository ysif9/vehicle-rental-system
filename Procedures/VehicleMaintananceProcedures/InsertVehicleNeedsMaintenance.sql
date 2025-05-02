CREATE PROCEDURE InsertVehicleNeedsMaintenance
    @Maintenance_Number INT,
    @CarID              INT
AS
BEGIN
    INSERT INTO Vehicle_Needs_Maintenance (Maintenance_Number, CarID)
    VALUES (@Maintenance_Number, @CarID);
END;
GO

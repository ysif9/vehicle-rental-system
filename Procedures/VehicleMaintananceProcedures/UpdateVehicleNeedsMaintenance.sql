CREATE PROCEDURE UpdateVehicleNeedsMaintenance
    @Old_Maintenance_Number INT,
    @Old_CarID              INT,
    @New_Maintenance_Number INT,
    @New_CarID              INT
AS
BEGIN
    DELETE FROM Vehicle_Needs_Maintenance
    WHERE Maintenance_Number = @Old_Maintenance_Number AND CarID = @Old_CarID;

    INSERT INTO Vehicle_Needs_Maintenance (Maintenance_Number, CarID)
    VALUES (@New_Maintenance_Number, @New_CarID);
END;
GO

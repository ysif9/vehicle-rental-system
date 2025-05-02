-- DeleteMaintenance procedure for Maintenance table
CREATE PROCEDURE DeleteMaintenance
    @Maintenance_Number INT
AS
BEGIN
    DELETE FROM Maintenance WHERE Maintenance_Number = @Maintenance_Number
END
GO

-- GetAllMaintenance procedure for Maintenance table
CREATE PROCEDURE GetAllMaintenance
AS
BEGIN
    SELECT Maintenance_Number, Service_Price, Company_Name, Date FROM Maintenance
END
GO

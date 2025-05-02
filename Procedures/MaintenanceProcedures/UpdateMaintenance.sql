-- UpdateMaintenance procedure for Maintenance table
CREATE PROCEDURE UpdateMaintenance
    @Maintenance_Number INT,
    @Service_Price DECIMAL(10,2),
    @Company_Name VARCHAR(100),
    @Date DATE
AS
BEGIN
    UPDATE Maintenance
    SET Service_Price = @Service_Price, Company_Name = @Company_Name, Date = @Date
    WHERE Maintenance_Number = @Maintenance_Number
END
GO

-- InsertMaintenance procedure for Maintenance table
CREATE PROCEDURE InsertMaintenance
    @Service_Price DECIMAL(10,2),
    @Company_Name VARCHAR(100),
    @Date DATE
AS
BEGIN
    INSERT INTO Maintenance (Service_Price, Company_Name, Date)
    VALUES (@Service_Price, @Company_Name, @Date)
END
GO

CREATE PROCEDURE UpdateVehicle
    @CarID INT,
    @Brand VARCHAR(50),
    @Model_Name VARCHAR(100),
    @Model_Year INT,
    @Type VARCHAR(50),
    @Color VARCHAR(30),
    @Number_of_Seats INT,
    @License_Expiry_Date DATE,
    @License_Number VARCHAR(50),
    @GarageID INT,
    @Availability_Status VARCHAR(30)
AS
BEGIN
    UPDATE Vehicle SET
        Brand = @Brand,
        Model_Name = @Model_Name,
        Model_Year = @Model_Year,
        Type = @Type,
        Color = @Color,
        Number_of_Seats = @Number_of_Seats,
        License_Expiry_Date = @License_Expiry_Date,
        License_Number = @License_Number,
        GarageID = @GarageID,
        Availability_Status = @Availability_Status
    WHERE CarID = @CarID;
END;

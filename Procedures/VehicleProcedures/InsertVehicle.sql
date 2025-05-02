CREATE PROCEDURE InsertVehicle
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
    INSERT INTO Vehicle (
        Brand, Model_Name, Model_Year, Type, Color,
        Number_of_Seats, License_Expiry_Date, License_Number,
        GarageID, Availability_Status
    )
    VALUES (
        @Brand, @Model_Name, @Model_Year, @Type, @Color,
        @Number_of_Seats, @License_Expiry_Date, @License_Number,
        @GarageID, @Availability_Status
    );

    SELECT SCOPE_IDENTITY();  -- Return new CarID
END;

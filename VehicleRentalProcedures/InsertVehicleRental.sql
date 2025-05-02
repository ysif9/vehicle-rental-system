CREATE PROCEDURE InsertVehicleRental
    @CarID INT,
    @RentalID INT,
    @Daily_price DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO Vehicle_Offered_For_Rental (CarID, RentalID, Daily_price)
    VALUES (@CarID, @RentalID, @Daily_price);
END;

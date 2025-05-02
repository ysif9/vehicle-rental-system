CREATE PROCEDURE UpdateVehicleRental
    @CarID INT,
    @RentalID INT,
    @Daily_price DECIMAL(10, 2)
AS
BEGIN
    UPDATE Vehicle_Offered_For_Rental
    SET Daily_price = @Daily_price
    WHERE CarID = @CarID AND RentalID = @RentalID;
END;

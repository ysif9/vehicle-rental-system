CREATE PROCEDURE DeleteVehicleRental
    @CarID INT,
    @RentalID INT
AS
BEGIN
    DELETE FROM Vehicle_Offered_For_Rental
    WHERE CarID = @CarID AND RentalID = @RentalID;
END;

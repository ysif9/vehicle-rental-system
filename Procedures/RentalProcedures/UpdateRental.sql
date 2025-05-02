CREATE PROCEDURE UpdateRental
    @RentalID INT,
    @StartDate DATE,
    @EndDate DATE,
    @Status VARCHAR(50),
    @CustomerID INT
AS
BEGIN
UPDATE Rental
SET Start_Date = @StartDate,
    End_Date = @EndDate,
    Rental_Status = @Status,
    CustomerID = @CustomerID
WHERE RentalID = @RentalID;
END;
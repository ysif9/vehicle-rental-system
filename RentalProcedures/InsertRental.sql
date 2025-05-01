CREATE PROCEDURE InsertRental
    @StartDate DATE,
    @EndDate DATE,
    @Status VARCHAR(50),
    @CustomerID INT
AS
BEGIN
INSERT INTO Rental (Start_Date, End_Date, Rental_Status, CustomerID)
VALUES (@StartDate, @EndDate, @Status, @CustomerID);

SELECT SCOPE_IDENTITY(); -- return the new RentalID
END;

CREATE PROCEDURE UpdatePayment
    @PaymentID INT,
    @Total_Price DECIMAL(10, 2),
    @Payment_Status VARCHAR(50),
    @Payment_Date DATE,
    @CustomerID INT,
    @RentalID INT
AS
BEGIN
UPDATE Payment
SET Total_Price = @Total_Price,
    Payment_Status = @Payment_Status,
    Payment_Date = @Payment_Date,
    CustomerID = @CustomerID,
    RentalID = @RentalID
WHERE PaymentID = @PaymentID;
END;

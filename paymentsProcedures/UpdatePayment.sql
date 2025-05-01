CREATE PROCEDURE UpdatePayment
    @PaymentID INT,
    @RentalID INT,
    @Amount DECIMAL(10,2),
    @PaymentDate DATE,
    @PaymentMethod VARCHAR(50),
    @Status VARCHAR(50)
AS
BEGIN
    UPDATE Payment
    SET RentalID = @RentalID,
        Amount = @Amount,
        Payment_Date = @PaymentDate,
        Payment_Method = @PaymentMethod,
        Status = @Status
    WHERE PaymentID = @PaymentID;
END; 
CREATE PROCEDURE InsertPayment
    @RentalID INT,
    @Amount DECIMAL(10,2),
    @PaymentDate DATE,
    @PaymentMethod VARCHAR(50),
    @Status VARCHAR(50)
AS
BEGIN
    INSERT INTO Payment (RentalID, Amount, Payment_Date, Payment_Method, Status)
    VALUES (@RentalID, @Amount, @PaymentDate, @PaymentMethod, @Status);

    SELECT SCOPE_IDENTITY(); -- return the new PaymentID
END; 
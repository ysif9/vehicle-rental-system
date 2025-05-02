CREATE PROCEDURE GetAllPayments
    AS
BEGIN
SELECT
    PaymentID,
    Total_Price,
    Payment_Status,
    Payment_Date,
    CustomerID,
    RentalID
FROM Payment;
END
GO

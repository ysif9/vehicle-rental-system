CREATE PROCEDURE InsertPayment
    @Total_Price DECIMAL(10, 2),
    @Payment_Status VARCHAR(50),
    @Payment_Date DATE,
    @CustomerID INT,
    @RentalID INT
AS
BEGIN
INSERT INTO Payment (Total_Price, Payment_Status, Payment_Date, CustomerID, RentalID)
VALUES (@Total_Price, @Payment_Status, @Payment_Date, @CustomerID, @RentalID);

SELECT SCOPE_IDENTITY(); -- return new PaymentID
END;

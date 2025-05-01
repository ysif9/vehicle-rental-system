CREATE PROCEDURE DeletePayment
    @PaymentID INT
AS
BEGIN
    DELETE FROM Payment WHERE PaymentID = @PaymentID;
END; 
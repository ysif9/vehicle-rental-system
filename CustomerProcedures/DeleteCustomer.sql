CREATE PROCEDURE DeleteCustomer
    @CustomerID INT
AS
BEGIN
    DELETE FROM Customer WHERE CustomerID = @CustomerID;
END; 
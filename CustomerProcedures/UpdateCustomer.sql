CREATE PROCEDURE UpdateCustomer
    @CustomerID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(100),
    @Phone VARCHAR(20),
    @Address VARCHAR(200),
    @LicenseNumber VARCHAR(50),
    @LicenseExpiry DATE
AS
BEGIN
    UPDATE Customer
    SET First_Name = @FirstName,
        Last_Name = @LastName,
        Email = @Email,
        Phone = @Phone,
        Address = @Address,
        License_Number = @LicenseNumber,
        License_Expiry = @LicenseExpiry
    WHERE CustomerID = @CustomerID;
END; 
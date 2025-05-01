CREATE PROCEDURE InsertCustomer
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(100),
    @Phone VARCHAR(20),
    @Address VARCHAR(200),
    @LicenseNumber VARCHAR(50),
    @LicenseExpiry DATE
AS
BEGIN
    INSERT INTO Customer (First_Name, Last_Name, Email, Phone, Address, License_Number, License_Expiry)
    VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @LicenseNumber, @LicenseExpiry);

    SELECT SCOPE_IDENTITY(); -- return the new CustomerID
END; 
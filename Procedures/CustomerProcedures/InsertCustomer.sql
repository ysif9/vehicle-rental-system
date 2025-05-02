CREATE PROCEDURE InsertCustomer
    @Customer_Name VARCHAR(100),
    @Address VARCHAR(255),
    @Date_of_Birth DATE,
    @Age INT,
    @Email VARCHAR(100),
    @Phone_Number VARCHAR(20),
    @Password VARCHAR(100),
    @License_Number VARCHAR(50),
    @License_Expiry_Date DATE,
    @License_Personal_Photo VARCHAR(MAX)
AS
BEGIN
INSERT INTO Customer (Customer_Name, Address, Date_of_Birth, Age, Email, Phone_Number, Password, License_Number, License_Expiry_Date, License_Personal_Photo)
VALUES (@Customer_Name, @Address, @Date_of_Birth, @Age, @Email, @Phone_Number, @Password, @License_Number, @License_Expiry_Date, @License_Personal_Photo);

SELECT SCOPE_IDENTITY(); -- return new CustomerID
END

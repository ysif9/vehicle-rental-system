CREATE PROCEDURE UpdateCustomer
    @CustomerID INT,
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
UPDATE Customer
SET Customer_Name = @Customer_Name,
    Address = @Address,
    Date_of_Birth = @Date_of_Birth,
    Age = @Age,
    Email = @Email,
    Phone_Number = @Phone_Number,
    Password = @Password,
    License_Number = @License_Number,
    License_Expiry_Date = @License_Expiry_Date,
    License_Personal_Photo = @License_Personal_Photo
WHERE CustomerID = @CustomerID;
END

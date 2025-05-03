-- ===========================
-- TABLE CREATION & Constrains
-- ===========================

-- CUSTOMER TABLE
CREATE TABLE Customer
(
    CustomerID             INT IDENTITY (1,1) PRIMARY KEY,
    Customer_Name          VARCHAR(100) NOT NULL,
    Address                VARCHAR(255),
    Date_of_Birth          DATE CHECK (Date_of_Birth <= GETDATE()),
    Age                    INT CHECK (Age >= 18 AND Age <= 100),
    Email                  VARCHAR(100) NOT NULL,
    Phone_Number           VARCHAR(20),
    Password               VARCHAR(100) NOT NULL,
    License_Number         VARCHAR(50)  NOT NULL,
    License_Expiry_Date    DATE         NOT NULL CHECK (License_Expiry_Date > GETDATE()),
    License_Personal_Photo VARCHAR(MAX),
    CONSTRAINT CHK_Email_Valid CHECK (Email LIKE '%@gmail.com' OR Email LIKE '%@yahoo.com')
);

-- RENTAL TABLE
CREATE INDEX IDX_Customer_Name ON Customer (Customer_Name);
CREATE INDEX IDX_Customer_Email ON Customer (Email);

CREATE TABLE Rental
(
    RentalID      INT IDENTITY (1,1) PRIMARY KEY,
    Start_Date    DATE NOT NULL,
    End_Date      DATE NOT NULL,
    Rental_Status VARCHAR(50) CHECK (Rental_Status IN ('Pending', 'Active', 'Cancelled', 'Completed')),
    CustomerID    INT  NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customer (CustomerID),
    CONSTRAINT CHK_Rental_Period CHECK (End_Date > Start_Date)
);

CREATE INDEX IDX_Rental_CustomerID ON Rental (CustomerID);

-- PAYMENT TABLE
CREATE TABLE Payment
(
    PaymentID      INT IDENTITY (1,1) PRIMARY KEY,
    Total_Price    DECIMAL(10, 2) NOT NULL CHECK (Total_Price >= 0),
    Payment_Status VARCHAR(50) CHECK (Payment_Status IN ('Pending', 'Paid', 'Failed')),
    Payment_Date   DATE           NOT NULL,
    CustomerID     INT            NOT NULL,
    RentalID       INT            NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customer (CustomerID),
    FOREIGN KEY (RentalID) REFERENCES Rental (RentalID)
);

CREATE INDEX IDX_Payment_CustomerID ON Payment (CustomerID);
CREATE INDEX IDX_Payment_RentalID ON Payment (RentalID);

-- MAINTENANCE TABLE
CREATE TABLE Maintenance
(
    Maintenance_Number INT IDENTITY (1,1) PRIMARY KEY,
    Service_Price      DECIMAL(10, 2) NOT NULL CHECK (Service_Price >= 0),
    Company_Name       VARCHAR(100)   NOT NULL,
    Date               DATE           NOT NULL CHECK (Date <= GETDATE())
);

CREATE INDEX IDX_Maintenance_Company_Name ON Maintenance (Company_Name);

-- Garage
CREATE TABLE Garage
(
    GarageID            INT IDENTITY (1,1) PRIMARY KEY,
    Garage_Name         VARCHAR(100) NOT NULL,
    Address             VARCHAR(255) NOT NULL,
    City                VARCHAR(100) NOT NULL,
    State               VARCHAR(100) NOT NULL,
    Manager_Name        VARCHAR(100) NOT NULL,
    Garage_Phone_Number VARCHAR(20)  NOT NULL,
    Vehicle_Count       INT DEFAULT 0 CHECK (Vehicle_Count >= 0),
    CONSTRAINT CHK_Phone_Format CHECK (
        Garage_Phone_Number LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR
        Garage_Phone_Number LIKE '[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]' OR
        Garage_Phone_Number LIKE '[0-9][0-9][0-9].[0-9][0-9][0-9].[0-9][0-9][0-9][0-9]')
);

CREATE INDEX IDX_Garage_Name ON Garage (Garage_Name);

--Vehicle
CREATE TABLE Vehicle
(
    CarID               INT IDENTITY (1,1) PRIMARY KEY,

    Brand               VARCHAR(50)  NOT NULL,
    Type                VARCHAR(50)  NOT NULL,
    Model_Name          VARCHAR(100) NOT NULL,
    Model_Year          INT          NOT NULL,
    Color               VARCHAR(30)  NOT NULL,
    Availability_Status VARCHAR(10)  NOT NULL,
    Number_of_Seats     INT          NOT NULL,
    License_Number      VARCHAR(6)   NOT NULL,
    License_Expiry_Date DATE         NOT NULL,
    GarageID            INT          NOT NULL,
    CONSTRAINT CHK_Vehicle_CarID_Positive CHECK (CarID > 0),
    CONSTRAINT CHK_Vehicle_ModelYear_Valid CHECK (Model_Year BETWEEN 1950 AND YEAR(GETDATE())),
    CONSTRAINT CHK_Vehicle_LicenseNumber_Format CHECK (
        License_Number LIKE '[A-Z][A-Z][A-Z][0-9][0-9][0-9]' AND
        LEN(License_Number) = 6
        ),
    CONSTRAINT CHK_Vehicle_Status_Valid CHECK (
        Availability_Status IN ('yes', 'no', 'Yes', 'No', 'YES', 'NO')
        ),
    CONSTRAINT FK_Vehicle_Garage FOREIGN KEY (GarageID) REFERENCES Garage (GarageID)
);


-- VEHICLE NEEDS MAINTENANCE (M:N RELATION)
CREATE TABLE Vehicle_Needs_Maintenance
(
    Maintenance_Number INT,
    CarID              INT,
    PRIMARY KEY (Maintenance_Number, CarID),
    FOREIGN KEY (Maintenance_Number) REFERENCES Maintenance (Maintenance_Number),
    FOREIGN KEY (CarID) REFERENCES Vehicle (CarID)
);

CREATE INDEX IDX_VNM_Maintenance_Number ON Vehicle_Needs_Maintenance (Maintenance_Number);
CREATE INDEX IDX_VNM_CarID ON Vehicle_Needs_Maintenance (CarID);

-- EMPLOYEE TABLE
CREATE TABLE Employee
(
    EmployeeID      INT IDENTITY (1,1) PRIMARY KEY,
    Name            VARCHAR(100) NOT NULL,
    Age             INT CHECK (Age >= 18 AND Age <= 65),
    Role            VARCHAR(50),
    Salary          DECIMAL(10, 2) CHECK (Salary >= 0),
    Enrollment_Date DATE         NOT NULL
);

CREATE INDEX IDX_Employee_Name ON Employee (Name);

-- REVIEWS TABLE
CREATE TABLE Reviews
(
    ReviewID      INT IDENTITY (1,1) PRIMARY KEY,
    RentalID      INT NOT NULL,
    Customer_Name VARCHAR(100),
    Feedback      VARCHAR(MAX),
    Rating        INT CHECK (Rating BETWEEN 1 AND 5),
    Checked_By    INT,
    Check_Report  VARCHAR(MAX),
    FOREIGN KEY (RentalID) REFERENCES Rental (RentalID),
    FOREIGN KEY (Checked_By) REFERENCES Employee (EmployeeID)
);

CREATE INDEX IDX_Review_RentalID ON Reviews (RentalID);
CREATE INDEX IDX_Review_CheckedBy ON Reviews (Checked_By);


-- Vehicle rental
CREATE TABLE Vehicle_Offered_For_Rental
(
    RentalID    INT            NOT NULL,
    CarID       INT            NOT NULL,
    Daily_Price DECIMAL(10, 2) NOT NULL,
    CONSTRAINT PK_VehicleRental PRIMARY KEY (RentalID, CarID),
    CONSTRAINT CHK_VehicleRental_DailyPrice_Positive CHECK (Daily_Price >= 0),
    CONSTRAINT FK_VehicleRental_Rental FOREIGN KEY (RentalID) REFERENCES Rental (RentalID),
    CONSTRAINT FK_VehicleRental_Car FOREIGN KEY (CarID) REFERENCES Vehicle (CarID)
);

-- Employee Garage
CREATE TABLE Employee_Works_For_Garage
(
    EmployeeID INT,
    GarageID   INT,
    PRIMARY KEY (EmployeeID, GarageID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee (EmployeeID) ON DELETE CASCADE,
    FOREIGN KEY (GarageID) REFERENCES Garage (GarageID) ON DELETE CASCADE
);

CREATE INDEX IDX_EWG_EmployeeID ON Employee_Works_For_Garage (EmployeeID);
CREATE INDEX IDX_EWG_GarageID ON Employee_Works_For_Garage (GarageID);


-- ===========================
-- SAMPLE DATA INSERTION (FIXED)
-- ===========================

-- CUSTOMER
INSERT INTO Customer (Customer_Name, Address, Date_of_Birth, Age, Email, Phone_Number, Password, License_Number,
                      License_Expiry_Date, License_Personal_Photo)
VALUES ('Ahmed Ali', '123 Tahrir St, Cairo', '1995-06-15', 29, 'ahmed.ali@gmail.com', '01234567890',
        'hashed_password_123', 'L-987654', '2026-12-31', NULL),
       ('Mona Youssef', '456 Zamalek Rd, Giza', '1988-03-10', 36, 'mona88@yahoo.com', '01111222333', 'secure_pass_456',
        'L-123456', '2027-07-15', NULL);

-- RENTAL
INSERT INTO Rental (Start_Date, End_Date, Rental_Status, CustomerID)
VALUES ('2025-05-10', '2025-05-15', 'Pending', 1),
       ('2025-06-01', '2025-06-05', 'Pending', 2);

-- PAYMENT
INSERT INTO Payment (Total_Price, Payment_Status, Payment_Date, CustomerID, RentalID)
VALUES (1500.00, 'Paid', '2025-05-09', 1, 1),
       (1200.00, 'Pending', '2025-05-30', 2, 2);

-- MAINTENANCE
INSERT INTO Maintenance (Service_Price, Company_Name, Date)
VALUES (500.00, 'AutoFix Cairo', '2025-04-15'),
       (750.00, 'FastTrack Maintenance', '2025-04-20');

-- GARAGE
INSERT INTO Garage (Garage_Name, Address, City, State, Manager_Name, Garage_Phone_Number, Vehicle_Count)
VALUES ('Downtown Garage', '123 Main St', 'Cairo', 'Cairo', 'Jane Smith', '01012345672', 15),
       ('Westside Garage', '456 Oak Ave', 'Giza', 'Giza', 'John Doe', '01198765432', 10);

-- VEHICLE
INSERT INTO Vehicle (Brand, Type, Model_Name, Model_Year, Color, Availability_Status, Number_of_Seats, License_Number,
                     License_Expiry_Date, GarageID)
VALUES ('Honda', 'Sedan', 'Civic', 2021, 'Red', 'yes', 5, 'ABC123', '2026-12-31', 1),
       ('Toyota', 'SUV', 'Corolla', 2022, 'Blue', 'no', 7, 'XYZ789', '2027-08-15', 2),
       ('BMW', 'Coupe', 'M4', 2020, 'Black', 'yes', 4, 'BMW987', '2025-11-25', 1),
       ('Ford', 'Truck', 'F-150', 2019, 'White', 'yes', 2, 'FRE001', '2026-03-01', 2),
       ('Chevrolet', 'Sedan', 'Malibu', 2023, 'Silver', 'no', 5, 'CHE123', '2027-06-10', 1);


-- VEHICLE_MAINTENANCE
INSERT INTO Vehicle_Needs_Maintenance (Maintenance_Number, CarID)
VALUES (1, 1),
       (1, 2),
       (2, 1);

-- EMPLOYEE
INSERT INTO Employee (Name, Age, Role, Salary, Enrollment_Date)
VALUES ('Youssef Sami', 30, 'Mechanic', 5000.00, '2024-01-10'),
       ('Sara Mahmoud', 40, 'Reviewer', 6000.00, '2023-11-01'),
       ('John Doe', 35, 'Mechanic', 50000.00, '2023-01-15'),
       ('Jane Smith', 28, 'Manager', 60000.00, '2022-06-10'),
       ('Mike Johnson', 40, 'Technician', 45000.00, '2023-03-20');

-- EMPLOYEE_WORKS_FOR_GARAGE
INSERT INTO Employee_Works_For_Garage (EmployeeID, GarageID)
VALUES (3, 1), -- John Doe
       (4, 1), -- Jane Smith
       (5, 2), -- Mike Johnson
       (3, 2);

-- REVIEWS
INSERT INTO Reviews (RentalID, Customer_Name, Feedback, Rating, Checked_By, Check_Report)
VALUES (1, 'Ahmed Ali', 'The car was clean and in good condition.', 5, 2, 'Verified - Clean condition'),
       (2, 'Mona Youssef', 'Vehicle had minor scratches.', 3, 2, 'Verified - Reported scratches');

--Select all garages with their managers and vehicle counts
SELECT Garage_Name, Address, City, State, Manager_Name, Garage_Phone_Number, Vehicle_Count
FROM Garage
ORDER BY Vehicle_Count DESC;

--Find employees working at a specific garage
SELECT e.Name, e.Role, g.Garage_Name
FROM Employee e
         JOIN Employee_Works_For_Garage ewg ON e.EmployeeID = ewg.EmployeeID
         JOIN Garage g ON ewg.GarageID = g.GarageID
WHERE g.Garage_Name = 'Downtown Garage';

--Count employees per garage
SELECT g.Garage_Name, COUNT(ewg.EmployeeID) as EmployeeCount
FROM Garage g
         LEFT JOIN Employee_Works_For_Garage ewg ON g.GarageID = ewg.GarageID
GROUP BY g.Garage_Name;

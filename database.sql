-- CUSTOMER
CREATE TABLE Customer
(
    CustomerID             INT IDENTITY (1,1) PRIMARY KEY,
    Customer_Name          VARCHAR(100),
    Address                VARCHAR(255),
    Date_of_Birth          DATE,
    Age                    INT,
    Email                  VARCHAR(100),
    Phone_Number           VARCHAR(20),
    Password               VARCHAR(100),
    License_Number         VARCHAR(50),
    License_Expiry_Date    DATE,
    License_Personal_Photo varchar(max)
);

-- RENTAL
CREATE TABLE Rental
(
    RentalID      INT IDENTITY (1,1) PRIMARY KEY,
    Start_Date    DATE,
    End_Date      DATE,
    Rental_Status VARCHAR(50),
    CustomerID    INT,
    FOREIGN KEY (CustomerID) REFERENCES Customer (CustomerID)
);

-- PAYMENT
CREATE TABLE Payment
(
    PaymentID      INT IDENTITY (1,1) PRIMARY KEY,
    Total_Price    DECIMAL(10, 2),
    Payment_Status VARCHAR(50),
    Payment_Date   DATE,
    CustomerID     INT,
    RentalID       INT,
    FOREIGN KEY (CustomerID) REFERENCES Customer (CustomerID),
    FOREIGN KEY (RentalID) REFERENCES Rental (RentalID)
);

-- MAINTENANCE
CREATE TABLE Maintenance
(
    Maintenance_Number INT IDENTITY (1,1) PRIMARY KEY,
    Service_Price      DECIMAL(10, 2),
    Company_Name       VARCHAR(100),
    Date               DATE
);

-- GARAGE
CREATE TABLE Garage
(
    GarageID            INT IDENTITY (1,1) PRIMARY KEY,
    Garage_Name         VARCHAR(100),
    Address             VARCHAR(255),
    City                VARCHAR(100),
    State               VARCHAR(100),
    Manager_Name        VARCHAR(100),
    Garage_Phone_Number VARCHAR(20),
    Vehicle_Count       INT
);

-- VEHICLE
CREATE TABLE Vehicle
(
    CarID               INT IDENTITY (1,1) PRIMARY KEY,
    Brand               VARCHAR(50),
    Type                VARCHAR(50),
    Model_Name          VARCHAR(100),
    Model_Year          INT,
    Color               VARCHAR(30),
    Availability_Status VARCHAR(30),
    Number_of_Seats     INT,
    License_Number      VARCHAR(50),
    License_Expiry_Date DATE,
    GarageID            INT,
    FOREIGN KEY (GarageID) REFERENCES Garage (GarageID)
);

-- VEHICLE_RENTAL (M:N between Vehicle and Rental)
CREATE TABLE Vehicle_Offered_For_Rental
(
    RentalID    INT,
    CarID       INT,
    Offered_For VARCHAR(50),
    Daily_Price DECIMAL(10, 2),
    PRIMARY KEY (RentalID, CarID),
    FOREIGN KEY (RentalID) REFERENCES Rental (RentalID),
    FOREIGN KEY (CarID) REFERENCES Vehicle (CarID)
);

-- VEHICLE_MAINTENANCE (M:N)
CREATE TABLE Vehicle_Needs_Maintenance
(
    Maintenance_Number INT,
    CarID              INT,
    PRIMARY KEY (Maintenance_Number, CarID),
    FOREIGN KEY (Maintenance_Number) REFERENCES Maintenance (Maintenance_Number),
    FOREIGN KEY (CarID) REFERENCES Vehicle (CarID)
);

-- EMPLOYEE
CREATE TABLE Employee
(
    EmployeeID      INT IDENTITY (1,1) PRIMARY KEY,
    Name            VARCHAR(100),
    Age             INT,
    Role            VARCHAR(50),
    Salary          DECIMAL(10, 2),
    Enrollment_Date DATE
);

-- EMPLOYEE_GARAGE (N:M)
CREATE TABLE Employee_Works_For_Garage
(
    EmployeeID INT,
    GarageID   INT,
    PRIMARY KEY (EmployeeID, GarageID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee (EmployeeID),
    FOREIGN KEY (GarageID) REFERENCES Garage (GarageID)
);

-- REVIEWS
CREATE TABLE Reviews
(
    ReviewID      INT IDENTITY (1,1) PRIMARY KEY,
    RentalID      INT,
    Customer_Name VARCHAR(100),
    Feedback      varchar(max),
    Rating        INT,
    Checked_By    INT,
    Check_Report  varchar(max),
    FOREIGN KEY (RentalID) REFERENCES Rental (RentalID),
    FOREIGN KEY (Checked_By) REFERENCES Employee (EmployeeID)
);
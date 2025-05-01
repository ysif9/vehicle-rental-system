-- Test Customer Procedures
PRINT 'Testing Customer Procedures...'
GO

-- Test InsertCustomer
DECLARE @NewCustomerID INT;
EXEC @NewCustomerID = InsertCustomer
    @FirstName = 'John',
    @LastName = 'Doe',
    @Email = 'john.doe@example.com',
    @Phone = '1234567890',
    @Address = '123 Main St',
    @LicenseNumber = 'DL123456',
    @LicenseExpiry = '2025-12-31';

PRINT 'New Customer ID: ' + CAST(@NewCustomerID AS VARCHAR(10));

-- Test UpdateCustomer
EXEC UpdateCustomer
    @CustomerID = @NewCustomerID,
    @FirstName = 'John',
    @LastName = 'Smith',
    @Email = 'john.smith@example.com',
    @Phone = '0987654321',
    @Address = '456 Oak St',
    @LicenseNumber = 'DL123456',
    @LicenseExpiry = '2025-12-31';

PRINT 'Customer Updated Successfully';

-- Test DeleteCustomer
EXEC DeleteCustomer @CustomerID = @NewCustomerID;
PRINT 'Customer Deleted Successfully';

-- Test Payment Procedures
PRINT 'Testing Payment Procedures...'
GO

-- Test InsertPayment
DECLARE @NewPaymentID INT;
EXEC @NewPaymentID = InsertPayment
    @RentalID = 1,
    @Amount = 100.00,
    @PaymentDate = '2024-05-01',
    @PaymentMethod = 'Credit Card',
    @Status = 'Completed';

PRINT 'New Payment ID: ' + CAST(@NewPaymentID AS VARCHAR(10));

-- Test UpdatePayment
EXEC UpdatePayment
    @PaymentID = @NewPaymentID,
    @RentalID = 1,
    @Amount = 150.00,
    @PaymentDate = '2024-05-01',
    @PaymentMethod = 'Credit Card',
    @Status = 'Completed';

PRINT 'Payment Updated Successfully';

-- Test DeletePayment
EXEC DeletePayment @PaymentID = @NewPaymentID;
PRINT 'Payment Deleted Successfully';

-- Test Maintenance Procedures
PRINT 'Testing Maintenance Procedures...'
GO

-- Test InsertMaintenance
DECLARE @NewMaintenanceID INT;
EXEC @NewMaintenanceID = InsertMaintenance
    @VehicleID = 1,
    @MaintenanceDate = '2024-05-01',
    @Description = 'Regular oil change',
    @Cost = 50.00,
    @Status = 'Completed';

PRINT 'New Maintenance ID: ' + CAST(@NewMaintenanceID AS VARCHAR(10));

-- Test UpdateMaintenance
EXEC UpdateMaintenance
    @MaintenanceID = @NewMaintenanceID,
    @VehicleID = 1,
    @MaintenanceDate = '2024-05-01',
    @Description = 'Regular oil change and filter replacement',
    @Cost = 75.00,
    @Status = 'Completed';

PRINT 'Maintenance Updated Successfully';

-- Test DeleteMaintenance
EXEC DeleteMaintenance @MaintenanceID = @NewMaintenanceID;
PRINT 'Maintenance Deleted Successfully';

-- Test Review Procedures
PRINT 'Testing Review Procedures...'
GO

-- Test InsertReview
DECLARE @NewReviewID INT;
EXEC @NewReviewID = InsertReview
    @RentalID = 1,
    @Rating = 5,
    @Comment = 'Great service!',
    @ReviewDate = '2024-05-01';

PRINT 'New Review ID: ' + CAST(@NewReviewID AS VARCHAR(10));

-- Test UpdateReview
EXEC UpdateReview
    @ReviewID = @NewReviewID,
    @RentalID = 1,
    @Rating = 4,
    @Comment = 'Very good service, but could be improved',
    @ReviewDate = '2024-05-01';

PRINT 'Review Updated Successfully';

-- Test DeleteReview
EXEC DeleteReview @ReviewID = @NewReviewID;
PRINT 'Review Deleted Successfully';

-- Test Rental Procedures
PRINT 'Testing Rental Procedures...'
GO

-- Test InsertRental
DECLARE @NewRentalID INT;
EXEC @NewRentalID = InsertRental
    @StartDate = '2024-05-01',
    @EndDate = '2024-05-07',
    @Status = 'Active',
    @CustomerID = 1;

PRINT 'New Rental ID: ' + CAST(@NewRentalID AS VARCHAR(10));

-- Test UpdateRental
EXEC UpdateRental
    @RentalID = @NewRentalID,
    @StartDate = '2024-05-01',
    @EndDate = '2024-05-08',
    @Status = 'Extended',
    @CustomerID = 1;

PRINT 'Rental Updated Successfully';

-- Test DeleteRental
EXEC DeleteRental @RentalID = @NewRentalID;
PRINT 'Rental Deleted Successfully'; 
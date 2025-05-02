CREATE PROCEDURE InsertReview
    @RentalID INT,
    @Customer_Name VARCHAR(100),
    @Feedback VARCHAR(MAX),
    @Rating INT,
    @Checked_By INT,
    @Check_Report VARCHAR(MAX)
AS
BEGIN
    INSERT INTO Reviews (RentalID, Customer_Name, Feedback, Rating, Checked_By, Check_Report)
    VALUES (@RentalID, @Customer_Name, @Feedback, @Rating, @Checked_By, @Check_Report);

    SELECT SCOPE_IDENTITY(); -- Returns newly inserted ReviewID
END

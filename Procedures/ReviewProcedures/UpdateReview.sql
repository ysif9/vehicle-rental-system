CREATE PROCEDURE UpdateReview
    @ReviewID INT,
    @RentalID INT,
    @Customer_Name VARCHAR(100),
    @Feedback VARCHAR(MAX),
    @Rating INT,
    @Checked_By INT,
    @Check_Report VARCHAR(MAX)
AS
BEGIN
UPDATE Reviews
SET
    RentalID = @RentalID,
    Customer_Name = @Customer_Name,
    Feedback = @Feedback,
    Rating = @Rating,
    Checked_By = @Checked_By,
    Check_Report = @Check_Report
WHERE ReviewID = @ReviewID;
END

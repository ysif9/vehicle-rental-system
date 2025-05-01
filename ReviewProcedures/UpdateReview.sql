CREATE PROCEDURE UpdateReview
    @ReviewID INT,
    @RentalID INT,
    @Rating INT,
    @Comment VARCHAR(500),
    @ReviewDate DATE
AS
BEGIN
    UPDATE Review
    SET RentalID = @RentalID,
        Rating = @Rating,
        Comment = @Comment,
        Review_Date = @ReviewDate
    WHERE ReviewID = @ReviewID;
END; 
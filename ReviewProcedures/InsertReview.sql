CREATE PROCEDURE InsertReview
    @RentalID INT,
    @Rating INT,
    @Comment VARCHAR(500),
    @ReviewDate DATE
AS
BEGIN
    INSERT INTO Review (RentalID, Rating, Comment, Review_Date)
    VALUES (@RentalID, @Rating, @Comment, @ReviewDate);

    SELECT SCOPE_IDENTITY(); -- return the new ReviewID
END; 
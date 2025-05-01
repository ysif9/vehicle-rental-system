CREATE PROCEDURE DeleteReview
    @ReviewID INT
AS
BEGIN
    DELETE FROM Review WHERE ReviewID = @ReviewID;
END; 
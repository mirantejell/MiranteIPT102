CREATE PROCEDURE [dbo].[GetLibraryById]
    @LibraryId INT
AS
BEGIN
    SELECT
        LibraryId,
        LibraryName,
        Address,
        Email,
        ContactNumber
    FROM [dbo].[Library]
    WHERE LibraryId = @LibraryId;
END
GO

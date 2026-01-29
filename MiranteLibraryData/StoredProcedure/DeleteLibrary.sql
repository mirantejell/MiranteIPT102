CREATE PROCEDURE [dbo].[DeleteLibrary]
    @LibraryId INT
AS
BEGIN
    DELETE FROM [dbo].[Library]
    WHERE LibraryId = @LibraryId;
END
GO

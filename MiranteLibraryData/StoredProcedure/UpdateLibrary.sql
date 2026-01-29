CREATE PROCEDURE [dbo].[UpdateLibrary]
    @LibraryId INT,
    @LibraryName NVARCHAR(150),
    @Address NVARCHAR(255),
    @Email NVARCHAR(100),
    @ContactNumber NVARCHAR(20)
AS
BEGIN
    UPDATE [dbo].[Library]
    SET
        LibraryName = @LibraryName,
        Address = @Address,
        Email = @Email,
        ContactNumber = @ContactNumber
    WHERE LibraryId = @LibraryId;
END
GO

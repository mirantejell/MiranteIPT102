CREATE PROCEDURE [dbo].[CreateLibrary]
    @LibraryName NVARCHAR(150),
    @Address NVARCHAR(255),
    @Email NVARCHAR(100),
    @ContactNumber NVARCHAR(20)
AS
BEGIN
    INSERT INTO [dbo].[Library]
    (
        LibraryName,
        Address,
        Email,
        ContactNumber
    )
    VALUES
    (
        @LibraryName,
        @Address,
        @Email,
        @ContactNumber
    );
END
GO

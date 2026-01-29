CREATE TABLE [dbo].[Library]
(
    [LibraryId] INT IDENTITY(1,1) PRIMARY KEY,
    [LibraryName] NVARCHAR(150) NOT NULL,
    [Address] NVARCHAR(255) NOT NULL,
    [Email] NVARCHAR(100),
    [ContactNumber] NVARCHAR(20)
);

CREATE TABLE [dbo].[AssetTypes]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(100) NOT NULL, 
    [RecordCreatedDate] DATETIME2 NOT NULL, 
    [RecordLastUpdatedDate] DATETIME2 NULL
)

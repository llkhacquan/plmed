CREATE TABLE [Sales].[Product]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [code] NCHAR(100) NULL, 
	[name] NCHAR(100) NULL, 
	[price] BIGINT NULL,
    [type] NCHAR(100) NULL
)

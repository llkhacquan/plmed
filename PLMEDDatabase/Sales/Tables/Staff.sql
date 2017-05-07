CREATE TABLE [Sales].[Staff]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [code] NCHAR(100) NOT NULL, 
    [name] NCHAR(100) NOT NULL, 
	[telephone] NCHAR(100) NULL, 
    [position] NCHAR(100) NULL, 
	[address] NCHAR(100) NULL,
    [start] DATE NULL,
	[birthday] DATE NULL
)

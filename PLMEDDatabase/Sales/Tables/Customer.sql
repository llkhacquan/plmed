CREATE TABLE [Sales].[Customer]
(
	[id] INT NOT NULL IDENTITY  , 
    [name] NCHAR(100) NOT NULL, 
    [email] NCHAR(100) NULL, 
    [taxcode] NCHAR(100) NULL, 
    [category] NCHAR(100) NULL, 
    [address] NCHAR(100) NULL, 
    [telephone] NCHAR(120) NULL, 
    [contact] NCHAR(100) NULL, 
    CONSTRAINT [PK_Customer] PRIMARY KEY ([id])
)

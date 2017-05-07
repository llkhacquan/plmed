﻿CREATE TABLE [Sales].[Contract]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [code] NCHAR(100) NULL, 
    [signdate] DATETIME NULL, 
    [customer_id] INT NOT NULL, 
    [staff_id] INT NOT NULL, 
    [value] BIGINT NULL, 
    CONSTRAINT [FK_customer_id] FOREIGN KEY (customer_id) REFERENCES [Sales].[Customer](id),
	CONSTRAINT [FK_staff_id] FOREIGN KEY (staff_id) REFERENCES [Sales].[Staff](id)
)

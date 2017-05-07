CREATE PROCEDURE [Sales].[selectContract] 
AS
BEGIN  
	SELECT [Con].[id], [Con].[name], [Cus].[name], [Sta].[name], [Con].[value], [Con].[signdate]
	FROM [Sales].[Contract] AS Con 
	INNER JOIN [Sales].[Customer] AS Cus
			ON [Con].[customer_id] = [Cus].[id]
	INNER JOIN [Sales].[Staff] AS Sta
			ON [Con].[staff_id] = [Sta].[id]
END
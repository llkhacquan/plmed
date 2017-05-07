CREATE PROCEDURE [Sales].[searchContract] 
@query NVARCHAR (100)
AS
BEGIN  
	SELECT [Con].[id], [Con].[name], [Cus].[name], [Sta].[name], [Con].[value], [Con].[signdate]
	FROM [Sales].[Contract] AS Con 
	INNER JOIN [Sales].[Customer] AS Cus
			ON [Con].[customer_id] = [Cus].[id]
	INNER JOIN [Sales].[Staff] AS Sta
			ON [Con].[staff_id] = [Sta].[id]
	WHERE UPPER([Con].[name]) like '%' + @query + '%'
	OR	UPPER([Con].[name]) like '%' + @query + '%'
	OR	UPPER([Cus].[name]) like '%' + @query + '%'
	OR	UPPER([Sta].[name]) like '%' + @query + '%'
	OR	STR([Con].[value]) like '%' + @query + '%'
	OR	STR([Con].[id]) like '%' + @query + '%'
	OR	FORMAT([Con].[signdate], 'dd/MM/yyyy') like '%' + @query + '%'
END
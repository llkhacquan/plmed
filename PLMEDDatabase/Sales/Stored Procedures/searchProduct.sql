CREATE PROCEDURE [Sales].[searchProduct] 
@query NVARCHAR (100)
AS
BEGIN  
	SELECT [id] AS 'Id', 
		[code] AS 'Mã nhân viên', 
		[name] AS 'Tên nhân viên',
		price AS 'Giá',
		type AS 'Mặt hàng'
	FROM [Sales].Product
	WHERE 
		STR([id]) like '%' + @query + '%'
	OR	UPPER([name]) like '%' + @query + '%'
	OR	UPPER(code) like '%' + @query + '%'
	OR	UPPER(type) like '%' + @query + '%'
	OR	STR([price]) like '%' + @query + '%'
END
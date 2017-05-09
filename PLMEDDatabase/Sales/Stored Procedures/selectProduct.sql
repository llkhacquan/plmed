CREATE PROCEDURE [Sales].[selectProduct] 
AS
BEGIN  
	SELECT [id] AS 'Id', 
		[code] AS 'Mã', 
		[name] AS 'Tên',
		price AS 'Giá',
		type AS 'Mặt hàng'
	FROM [Sales].Product
END
CREATE PROCEDURE [Sales].[exportContractC] 
@fromdate DATE,
@todate DATE,
@customer_id INT
AS
BEGIN  
	SELECT [Con].[id] AS 'Id', 
		[Con].[code] AS 'Mã hợp đồng', 
		[Con].[name] AS 'Tên hợp đồng', 
		[Cus].[name] AS 'Tên khách hàng', 
		[Sta].[name] AS 'Tên nhân viên', 
		[Con].[value] AS 'Giá trị', 
		[Con].[signdate] AS 'Ngày ký hợp đồng'
	FROM [Sales].[Contract] AS Con 
	INNER JOIN [Sales].[Customer] AS Cus
			ON [Con].[customer_id] = [Cus].[id]
	INNER JOIN [Sales].[Staff] AS Sta
			ON [Con].[staff_id] = [Sta].[id]
	WHERE 
		@fromdate <= [Con].[signdate] 
	AND [Con].[signdate] <= @todate
	AND @customer_id = [Cus].[id]
END
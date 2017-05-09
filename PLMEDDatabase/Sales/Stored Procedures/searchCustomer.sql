CREATE PROCEDURE [Sales].[searchCustomer] 
@query NVARCHAR (100)
AS
BEGIN  
	SELECT [id] AS 'Id', 
		[name] AS 'Tên doanh nghiệp', 
		[email] AS 'Email',
		[taxcode] AS 'Mã số thuế',
		[category] AS 'Ngành nghề',
		[address] AS 'Địa chỉ',
		[telephone] AS 'Số điện thoại',
		[contact] AS 'Người liên lạc'
	FROM [Sales].[Customer]
	WHERE 
		STR([id]) like '%' + @query + '%'
	OR	UPPER([name]) like '%' + @query + '%'
	OR	UPPER([email]) like '%' + @query + '%'
	OR	UPPER([email]) like '%' + @query + '%'
	OR	UPPER([taxcode]) like '%' + @query + '%'
	OR	UPPER([category]) like '%' + @query + '%'
	OR	UPPER([address]) like '%' + @query + '%'
	OR	UPPER([contact]) like '%' + @query + '%'
END
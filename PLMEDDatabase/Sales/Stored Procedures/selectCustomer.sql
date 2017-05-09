CREATE PROCEDURE [Sales].[selectCustomer] 
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
END
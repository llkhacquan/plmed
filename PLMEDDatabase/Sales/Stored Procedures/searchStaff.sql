CREATE PROCEDURE [Sales].[searchStaff] 
@query NVARCHAR (100)
AS
BEGIN  
	SELECT [id] AS 'Id', 
		[code] AS 'Mã nhân viên', 
		[name] AS 'Tên nhân viên',
		[telephone] AS 'Số điện thoại',
		[position] AS 'Vị trí',
		[address] AS 'Địa chỉ',
		[start] AS 'Ngày làm việc',
		[birthday] AS 'Sinh nhật'
	FROM [Sales].[Staff]
	WHERE 
		STR([id]) like '%' + @query + '%'
	OR	UPPER([name]) like '%' + @query + '%'
	OR	UPPER(code) like '%' + @query + '%'
	OR	UPPER([telephone]) like '%' + @query + '%'
	OR	UPPER([position]) like '%' + @query + '%'
	OR	UPPER([address]) like '%' + @query + '%'
	OR	FORMAT([start],'dd/MM/yyyy') like '%' + @query + '%'
	OR	FORMAT([birthday],'dd/MM/yyyy') like '%' + @query + '%'
END
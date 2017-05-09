CREATE PROCEDURE [Sales].[selectStaff] 
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
END
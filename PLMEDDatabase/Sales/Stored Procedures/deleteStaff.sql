CREATE PROCEDURE [Sales].[deleteStaff]
	@id INT
AS  
BEGIN  
	DELETE FROM [Sales].[Staff] WHERE id = @id;
	RETURN @@ERROR 
END
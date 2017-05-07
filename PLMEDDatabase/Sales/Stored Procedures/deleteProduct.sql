CREATE PROCEDURE [Sales].[deleteProduct]
	@id INT
AS  
BEGIN  
	DELETE FROM [Sales].[Product] WHERE id = @id;
	RETURN @@ERROR 
END
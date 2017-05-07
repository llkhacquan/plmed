CREATE PROCEDURE [Sales].[deleteContract]
	@id INT
AS  
BEGIN  
	DELETE FROM [Sales].[Contract] WHERE id = @id;
	RETURN @@ERROR 
END
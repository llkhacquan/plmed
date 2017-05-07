CREATE PROCEDURE [Sales].[uspDeleteCustomer]
@id INT
AS  
BEGIN  
DELETE FROM [Sales].[Customer] WHERE id = @id;
RETURN @@ERROR 
END
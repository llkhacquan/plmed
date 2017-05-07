CREATE PROCEDURE [Sales].[updateProduct]  
	@code NVARCHAR (100),  
	@name NVARCHAR (100),
	@type NVARCHAR (100),
	@price BIGINT,
	@id INT
AS  
BEGIN  
	UPDATE [Sales].[Product] SET name = @name, type = @type, code = @code, price = @price
	WHERE id = @id;
END
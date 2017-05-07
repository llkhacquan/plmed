CREATE PROCEDURE [Sales].[newProduct]
	@code NVARCHAR (100),  
	@name NVARCHAR (100),
	@type NVARCHAR (100),
	@price BIGINT,
	@id INT OUTPUT 
AS
	INSERT INTO [Sales].[Product] (code, name, type, price) VALUES (@code, @name, @type, @price);  
	SET @id = SCOPE_IDENTITY();  
	RETURN @@ERROR  
RETURN 0

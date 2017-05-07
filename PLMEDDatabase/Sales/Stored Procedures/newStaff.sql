CREATE PROCEDURE [Sales].[newStaff]
	@code NVARCHAR (100),  
	@name NVARCHAR (100),
	@telephone NVARCHAR (100),
	@position NVARCHAR (100),
	@address NVARCHAR (100),
	@start DATE,
	@birthday DATE,
	@id INT OUTPUT 
AS
	INSERT INTO [Sales].[Staff] (code, name, telephone, position, address, start, birthday) VALUES (@code, @name, @telephone, @position, @address, @start, @birthday);  
	SET @id = SCOPE_IDENTITY();  
	RETURN @@ERROR  
RETURN 0

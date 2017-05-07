CREATE PROCEDURE [Sales].[updateStaff]  
	@code NVARCHAR (100),  
	@name NVARCHAR (100),
	@telephone NVARCHAR (100),
	@position NVARCHAR (100),
	@address NVARCHAR (100),
	@start DATE,
	@birthday DATE,
	@id INT  
AS  
BEGIN  
	UPDATE [Sales].[Staff] SET name = @name, address = @address, telephone = @telephone, position = @position, start = @start, birthday = @birthday, code = @code
	WHERE id = @id;
END
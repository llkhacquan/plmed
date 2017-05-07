CREATE PROCEDURE [Sales].[newContract]
	@code NVARCHAR (100),  
	@name NVARCHAR (100),
	@customer_id INT,
	@staff_id INT,
	@value BIGINT,
	@signdate DATE,
	@id INT OUTPUT 
AS
	INSERT INTO [Sales].[Contract] (code, name, customer_id, staff_id, value, signdate) VALUES (@code, @name, @customer_id, @staff_id, @value, @signdate);  
	SET @id = SCOPE_IDENTITY();  
	RETURN @@ERROR  
RETURN 0

CREATE PROCEDURE [Sales].[updateContract]  
	@code NVARCHAR (100),  
	@name NVARCHAR (100),
	@customer_id INT,
	@staff_id INT,
	@value BIGINT,
	@signdate DATE,
	@id INT 
AS  
BEGIN  
	UPDATE [Sales].[Contract] SET name = @name, code = @code, customer_id= @customer_id, signdate = @signdate, staff_id = @staff_id, value = @value
	WHERE id = @id;
END
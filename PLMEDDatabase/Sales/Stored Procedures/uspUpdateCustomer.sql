CREATE PROCEDURE [Sales].[uspUpdateCustomer]  
@name NVARCHAR (100),  
@email NVARCHAR (100),  
@taxcode NVARCHAR (100),  
@category NVARCHAR (100),  
@address NVARCHAR (100),  
@telephone NVARCHAR (100),  
@contact NVARCHAR (100),
@id INT
AS  
BEGIN  
UPDATE [Sales].[Customer] SET name = @name, email = @email, taxcode = @taxcode, category = @category, address = @address, contact = @contact 
WHERE id = @id;
RETURN @@ERROR 
END
CREATE PROCEDURE [Sales].[uspNewCustomer]  
@name NVARCHAR (100),  
@email NVARCHAR (100),  
@taxcode NVARCHAR (100),  
@category NVARCHAR (100),  
@address NVARCHAR (100),  
@telephone NVARCHAR (100),  
@contact NVARCHAR (100),
@id INT OUTPUT 
AS  
BEGIN  
INSERT INTO [Sales].[Customer] (name, email, taxcode, category, address, telephone, contact) VALUES (@name, @email, @taxcode, @category, @address, @telephone, @contact);  
SET @id = SCOPE_IDENTITY();  
RETURN @@ERROR  
END
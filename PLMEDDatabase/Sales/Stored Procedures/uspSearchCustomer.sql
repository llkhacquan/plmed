CREATE PROCEDURE [Sales].[uspSearchCustomer]  
@query NVARCHAR (100)
AS  
BEGIN  
SELECT * FROM [Sales].[Customer]
WHERE STR(id) LIKE '%' + @query + '%'
OR name LIKE '%' + @query + '%'
OR email LIKE '%' + @query + '%'
OR taxcode LIKE '%' + @query + '%'
OR address LIKE '%' + @query + '%'
OR telephone LIKE '%' + @query + '%'
OR category LIKE '%' + @query + '%'
OR contact LIKE '%' + @query + '%'
RETURN @@ERROR 
END
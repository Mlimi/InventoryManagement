CREATE TABLE [dbo].[ProductDatabase]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Code] NCHAR(10) NULL, 
    [Name] NVARCHAR(50) NULL, 
    [Quantity Ordered] INT NOT NULL, 
    [Quantity Sold] INT NOT NULL, 
    [Order Price] MONEY NOT NULL, 
    [Sales Price] MONEY NOT NULL, 
    [Total Cost] MONEY NOT NULL, 
    [Net Earning] MONEY NOT NULL, 
    [Profit] MONEY NOT NULL, 
    [Order Date] SMALLDATETIME NOT NULL
)

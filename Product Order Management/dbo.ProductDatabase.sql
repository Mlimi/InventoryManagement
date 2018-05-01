CREATE TABLE [dbo].[ProductDatabase] (
    [Id]               INT           NOT NULL,
    [Code]             NCHAR (10)    NOT NULL,
    [Name]             NVARCHAR (50) NOT NULL,
    [QuantityOrdered] INT           NOT NULL,
    [QuantitySold]    INT           NOT NULL,
    [OrderPrice]      MONEY         NOT NULL,
    [SalesPrice]      MONEY         NOT NULL,
    [TotalCost]       MONEY         NOT NULL,
    [NetEarning]      MONEY         NOT NULL,
    [Profit]           MONEY         NOT NULL,
    [OrderDate]       SMALLDATETIME NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


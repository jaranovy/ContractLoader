CREATE TABLE [dbo].[Individuals] (
    [CustomerCode]          NVARCHAR (128) NOT NULL,
    [FirstName]             NVARCHAR (MAX) NULL,
    [LastName]              NVARCHAR (MAX) NULL,
    [Gender]                NVARCHAR (MAX) NULL,
    [DateOfBirth]           DATETIME       NOT NULL,
    [Contract_contractCode] NVARCHAR (128) NULL,
    CONSTRAINT [PK_dbo.Individuals] PRIMARY KEY CLUSTERED ([CustomerCode] ASC),
    CONSTRAINT [FK_dbo.Individuals_dbo.Contracts_Contract_contractCode] FOREIGN KEY ([Contract_contractCode]) REFERENCES [dbo].[Contracts] ([contractCode])
);


GO
CREATE NONCLUSTERED INDEX [IX_Contract_contractCode]
    ON [dbo].[Individuals]([Contract_contractCode] ASC);


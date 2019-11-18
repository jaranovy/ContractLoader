CREATE TABLE [dbo].[Individuals] (
    [CustomerCode] NVARCHAR (128) NOT NULL,
    [contractCode] NVARCHAR (128) NOT NULL,
    [FirstName]    NVARCHAR (MAX) NULL,
    [LastName]     NVARCHAR (MAX) NULL,
    [Gender]       NVARCHAR (MAX) NULL,
    [DateOfBirth]  DATETIME       NOT NULL,
    CONSTRAINT [PK_dbo.Individuals] PRIMARY KEY CLUSTERED ([CustomerCode] ASC, [contractCode] ASC),
    CONSTRAINT [FK_dbo.Individuals_dbo.Contracts_contractCode] FOREIGN KEY ([contractCode]) REFERENCES [dbo].[Contracts] ([contractCode]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_contractCode]
    ON [dbo].[Individuals]([contractCode] ASC);


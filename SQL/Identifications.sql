CREATE TABLE [dbo].[IdentificationNumbers] (
    [nationalID]              NVARCHAR (128) NOT NULL,
    [individual_CustomerCode] NVARCHAR (128) NULL,
    [individual_contractCode] NVARCHAR (128) NULL,
    CONSTRAINT [PK_dbo.IdentificationNumbers] PRIMARY KEY CLUSTERED ([nationalID] ASC),
    CONSTRAINT [FK_dbo.IdentificationNumbers_dbo.Individuals_individual_CustomerCode_individual_contractCode] FOREIGN KEY ([individual_CustomerCode], [individual_contractCode]) REFERENCES [dbo].[Individuals] ([CustomerCode], [contractCode])
);


GO
CREATE NONCLUSTERED INDEX [IX_individual_CustomerCode_individual_contractCode]
    ON [dbo].[IdentificationNumbers]([individual_CustomerCode] ASC, [individual_contractCode] ASC);


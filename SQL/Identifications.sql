CREATE TABLE [dbo].[IdentificationNumbers] (
    [nationalID]              NVARCHAR (128) NOT NULL,
    [individual_CustomerCode] NVARCHAR (128) NULL,
    CONSTRAINT [PK_dbo.IdentificationNumbers] PRIMARY KEY CLUSTERED ([nationalID] ASC),
    CONSTRAINT [FK_dbo.IdentificationNumbers_dbo.Individuals_individual_CustomerCode] FOREIGN KEY ([individual_CustomerCode]) REFERENCES [dbo].[Individuals] ([CustomerCode])
);


GO
CREATE NONCLUSTERED INDEX [IX_individual_CustomerCode]
    ON [dbo].[IdentificationNumbers]([individual_CustomerCode] ASC);


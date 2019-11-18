CREATE TABLE [dbo].[SubjectRoles] (
    [customerCode]             NVARCHAR (128)  NOT NULL,
    [contractCode]             NVARCHAR (128)  NOT NULL,
    [roleOfCustomer]           NVARCHAR (MAX)  NULL,
    [guaranteeAmount_value]    DECIMAL (18, 2) NOT NULL,
    [guaranteeAmount_currency] NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_dbo.SubjectRoles] PRIMARY KEY CLUSTERED ([customerCode] ASC, [contractCode] ASC),
    CONSTRAINT [FK_dbo.SubjectRoles_dbo.Contracts_contractCode] FOREIGN KEY ([contractCode]) REFERENCES [dbo].[Contracts] ([contractCode]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_contractCode]
    ON [dbo].[SubjectRoles]([contractCode] ASC);


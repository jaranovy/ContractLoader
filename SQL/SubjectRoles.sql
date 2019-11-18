CREATE TABLE [dbo].[SubjectRoles] (
    [customerCode]            NVARCHAR (128)  NOT NULL,
    [roleOfCustomer]          NVARCHAR (MAX)  NULL,
    [_guaranteeAmt]           DECIMAL (18, 2) NOT NULL,
    [_guaranteeAmtCurr]       NVARCHAR (MAX)  NULL,
    [originalAmount_amount]   DECIMAL (18, 2) NOT NULL,
    [originalAmount_currency] NVARCHAR (MAX)  NULL,
    [Contract_contractCode]   NVARCHAR (128)  NULL,
    CONSTRAINT [PK_dbo.SubjectRoles] PRIMARY KEY CLUSTERED ([customerCode] ASC),
    CONSTRAINT [FK_dbo.SubjectRoles_dbo.Contracts_Contract_contractCode] FOREIGN KEY ([Contract_contractCode]) REFERENCES [dbo].[Contracts] ([contractCode])
);


GO
CREATE NONCLUSTERED INDEX [IX_Contract_contractCode]
    ON [dbo].[SubjectRoles]([Contract_contractCode] ASC);


CREATE TABLE [dbo].[Contracts] (
    [contractCode]               NVARCHAR (128)  NOT NULL,
    [phaseOfContract]            NVARCHAR (MAX)  NULL,
    [originalAmount_value]       DECIMAL (18, 2) NOT NULL,
    [originalAmount_currency]    NVARCHAR (MAX)  NULL,
    [installmentAmount_value]    DECIMAL (18, 2) NOT NULL,
    [installmentAmount_currency] NVARCHAR (MAX)  NULL,
    [currentBalance_value]       DECIMAL (18, 2) NOT NULL,
    [currentBalance_currency]    NVARCHAR (MAX)  NULL,
    [overdueBalance_value]       DECIMAL (18, 2) NOT NULL,
    [overdueBalance_currency]    NVARCHAR (MAX)  NULL,
    [dateOfLastPayment]          DATETIME        NOT NULL,
    [nextPaymentDate]            DATETIME        NOT NULL,
    [dateAccountOpened]          DATETIME        NOT NULL,
    [realEndDate]                DATETIME        NOT NULL,
    CONSTRAINT [PK_dbo.Contracts] PRIMARY KEY CLUSTERED ([contractCode] ASC)
);


CREATE TABLE [dbo].[Contracts] (
    [contractCode]               NVARCHAR (128)  NOT NULL,
    [phaseOfContract]            NVARCHAR (MAX)  NULL,
    [_originalAmt]               DECIMAL (18, 2) NOT NULL,
    [_originalAmtCurr]           NVARCHAR (MAX)  NULL,
    [_installmentAmt]            DECIMAL (18, 2) NOT NULL,
    [_installmentAmtCurr]        NVARCHAR (MAX)  NULL,
    [_currentBal]                DECIMAL (18, 2) NOT NULL,
    [_currentBalCurr]            NVARCHAR (MAX)  NULL,
    [_overdueBal]                DECIMAL (18, 2) NOT NULL,
    [_overdueBalCurr]            NVARCHAR (MAX)  NULL,
    [dateOfLastPayment]          DATETIME        NOT NULL,
    [nextPaymentDate]            DATETIME        NOT NULL,
    [dateAccountOpened]          DATETIME        NOT NULL,
    [realEndDate]                DATETIME        NOT NULL,
    [originalAmount_amount]      DECIMAL (18, 2) NOT NULL,
    [originalAmount_currency]    NVARCHAR (MAX)  NULL,
    [installmentAmount_amount]   DECIMAL (18, 2) NOT NULL,
    [installmentAmount_currency] NVARCHAR (MAX)  NULL,
    [currentBalance_value]       DECIMAL (18, 2) NOT NULL,
    [currentBalance_currency]    NVARCHAR (MAX)  NULL,
    [overdueBalance_value]       DECIMAL (18, 2) NOT NULL,
    [overdueBalance_currency]    NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_dbo.Contracts] PRIMARY KEY CLUSTERED ([contractCode] ASC)
);

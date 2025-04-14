CREATE TABLE [dbo].[Payment] (
    [PaymentID]     INT             NOT NULL,
    [BookingID]     INT             NOT NULL,
    [Amount]        DECIMAL (10, 2) NOT NULL,
    [PaymentDate]   DATETIME        NOT NULL,
    [PaymentMethod] NVARCHAR (50)   NOT NULL,
    [TransactionID] NVARCHAR (100)  NULL,
    CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED ([PaymentID] ASC),
    CONSTRAINT [FK_Payment_Booking] FOREIGN KEY ([PaymentID]) REFERENCES [dbo].[Booking] ([BookingID])
);


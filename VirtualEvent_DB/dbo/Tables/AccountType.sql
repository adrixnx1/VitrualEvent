CREATE TABLE [dbo].[AccountType] (
    [AccountTypeID]   INT            IDENTITY (1, 1) NOT NULL,
    [AccountTypeName] NVARCHAR (100) NOT NULL,
    CONSTRAINT [FK_AccountType_UserID] FOREIGN KEY ([AccountTypeID]) REFERENCES [dbo].[UserID] ([UserID])
);


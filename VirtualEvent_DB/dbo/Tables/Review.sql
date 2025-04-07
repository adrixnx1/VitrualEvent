CREATE TABLE [dbo].[Review] (
    [ReviewID]   INT             NOT NULL,
    [UserID]     INT             NOT NULL,
    [TripID]     INT             NOT NULL,
    [Rating]     INT             NOT NULL,
    [Comment]    NVARCHAR (1000) NOT NULL,
    [ReviewDate] DATETIME        NOT NULL,
    CONSTRAINT [PK_Review] PRIMARY KEY CLUSTERED ([ReviewID] ASC),
    CONSTRAINT [FK_Review_UserID] FOREIGN KEY ([ReviewID]) REFERENCES [dbo].[UserID] ([UserID])
);


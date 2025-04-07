CREATE TABLE [dbo].[TripCollaboration] (
    [CollabID]     INT           NOT NULL,
    [TripID]       INT           NOT NULL,
    [UserID]       INT           NOT NULL,
    [Role]         NVARCHAR (50) NOT NULL,
    [InviteStatus] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_TripCollaboration] PRIMARY KEY CLUSTERED ([CollabID] ASC),
    CONSTRAINT [FK_TripCollaboration_UserID] FOREIGN KEY ([CollabID]) REFERENCES [dbo].[UserID] ([UserID])
);


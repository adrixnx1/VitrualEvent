CREATE TABLE [dbo].[UpcomingTrip] (
    [UpcomingTripID] INT            NOT NULL,
    [UserID]         INT            NOT NULL,
    [TripID]         INT            NOT NULL,
    [ReminderDate]   DATETIME       NULL,
    [Notes]          NVARCHAR (500) NULL,
    CONSTRAINT [PK_UpcomingTrip] PRIMARY KEY CLUSTERED ([UpcomingTripID] ASC),
    CONSTRAINT [FK_UpcomingTrip_UserID] FOREIGN KEY ([UpcomingTripID]) REFERENCES [dbo].[UserID] ([UserID])
);


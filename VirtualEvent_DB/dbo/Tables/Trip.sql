CREATE TABLE [dbo].[Trip] (
    [TripID]      INT             NOT NULL,
    [TripName]    NVARCHAR (200)  NOT NULL,
    [Description] NVARCHAR (1000) NOT NULL,
    [StartDate]   DATETIME        NOT NULL,
    [EndDate]     DATETIME        NOT NULL,
    [Price]       DECIMAL (10, 2) NOT NULL,
    [CountryID]   DATETIME        NULL,
    CONSTRAINT [PK_Trip] PRIMARY KEY CLUSTERED ([TripID] ASC),
    CONSTRAINT [FK_Trip_Booking] FOREIGN KEY ([TripID]) REFERENCES [dbo].[Booking] ([BookingID]),
    CONSTRAINT [FK_Trip_Country] FOREIGN KEY ([TripID]) REFERENCES [dbo].[Country] ([CountryID]),
    CONSTRAINT [FK_Trip_Review] FOREIGN KEY ([TripID]) REFERENCES [dbo].[Review] ([ReviewID]),
    CONSTRAINT [FK_Trip_TripCollaboration] FOREIGN KEY ([TripID]) REFERENCES [dbo].[TripCollaboration] ([CollabID]),
    CONSTRAINT [FK_Trip_UpcomingTrip] FOREIGN KEY ([TripID]) REFERENCES [dbo].[UpcomingTrip] ([UpcomingTripID])
);


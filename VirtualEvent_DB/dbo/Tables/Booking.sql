CREATE TABLE [dbo].[Booking] (
    [BookingID]   INT        IDENTITY (1, 1) NOT NULL,
    [UserID]      INT        NOT NULL,
    [TripID]      INT        NOT NULL,
    [BookingDate] DATETIME   NOT NULL,
    [Status]      NCHAR (50) NULL,
    CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED ([BookingID] ASC),
    CONSTRAINT [FK_Booking_UserID] FOREIGN KEY ([BookingID]) REFERENCES [dbo].[UserID] ([UserID])
);


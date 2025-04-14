CREATE TABLE [dbo].[Country] (
    [CountryID]   INT            NOT NULL,
    [CountryName] NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([CountryID] ASC),
    CONSTRAINT [FK_Country_Booking] FOREIGN KEY ([CountryID]) REFERENCES [dbo].[Booking] ([BookingID])
);


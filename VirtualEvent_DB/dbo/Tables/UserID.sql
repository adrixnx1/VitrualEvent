CREATE TABLE [dbo].[UserID] (
    [UserID]           INT         NOT NULL,
    [FirstName]        NCHAR (50)  NOT NULL,
    [LastName]         NCHAR (50)  NOT NULL,
    [Email]            NCHAR (100) NOT NULL,
    [Password]         NCHAR (100) NOT NULL,
    [ProfileImage]     NCHAR (500) NULL,
    [DateofBirth]      DATETIME    NULL,
    [RegistrationDate] DATETIME    NOT NULL,
    [AccountTypeID]    INT         NOT NULL,
    CONSTRAINT [PK_UserID] PRIMARY KEY CLUSTERED ([UserID] ASC)
);


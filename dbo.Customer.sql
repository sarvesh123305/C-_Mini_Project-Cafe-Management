CREATE TABLE [dbo].[Customer] (
    [Password]   VARCHAR (50) NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    [Mobile]     VARCHAR (50) NOT NULL,
    [Address]    VARCHAR (50) NOT NULL,
    [Email]      VARCHAR (50) NOT NULL UNIQUE,
    [AadharNo]   VARCHAR (50) NOT NULL UNIQUE,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([Mobile] ASC)
);


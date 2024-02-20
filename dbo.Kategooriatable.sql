CREATE TABLE [dbo].[Kategooriatable] (
    [Id]                 INT          identity(1,1) NOT NULL,
    [Kategooria_nimetus] VARCHAR (50) NOT NULL,
    [Kirjeldus]          TEXT         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


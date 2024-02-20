CREATE TABLE [dbo].[Toodetabel] (
    [Id]           INT          identity(1,1) NOT NULL,
    [Toodenimetus] VARCHAR (50) NOT NULL,
    [Kogus]        INT          NOT NULL,
    [Hind]         FLOAT (53)   NOT NULL,
    [Pilt]         TEXT         NULL,
    [Kategooriad]  INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


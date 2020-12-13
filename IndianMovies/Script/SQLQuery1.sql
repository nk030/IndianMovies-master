CREATE TABLE [dbo].[UpcomingMovies] (
    [UpcomingMovies_Id] INT            IDENTITY (1, 1) NOT NULL,
    [Movie_Name]        NVARCHAR (MAX) NULL,
    [Movie_Type]        NVARCHAR (MAX) NULL,
    [Release_Date]      DATETIME2 (7)  NOT NULL,
    [Movie_ID]          INT            NOT NULL,
    [Movie_objMovie_Id] INT            NULL,
    CONSTRAINT [PK_UpcomingMovies] PRIMARY KEY CLUSTERED ([UpcomingMovies_Id] ASC),
    CONSTRAINT [FK_UpcomingMovies_Movies_Movie_objMovie_Id] FOREIGN KEY ([Movie_objMovie_Id]) REFERENCES [dbo].[Movies] ([Movie_Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_UpcomingMovies_Movie_objMovie_Id]
    ON [dbo].[UpcomingMovies]([Movie_objMovie_Id] ASC);


    CREATE TABLE [dbo].[Ranking] (
    [Ranking_Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Movie_Name]        NVARCHAR (MAX) NULL,
    [India]             NVARCHAR (MAX) NULL,
    [Canada]            NVARCHAR (MAX) NULL,
    [Australia]         NVARCHAR (MAX) NULL,
    [Movie_ID]          INT            NOT NULL,
    [Movie_objMovie_Id] INT            NULL,
    CONSTRAINT [PK_Ranking] PRIMARY KEY CLUSTERED ([Ranking_Id] ASC),
    CONSTRAINT [FK_Ranking_Movies_Movie_objMovie_Id] FOREIGN KEY ([Movie_objMovie_Id]) REFERENCES [dbo].[Movies] ([Movie_Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Ranking_Movie_objMovie_Id]
    ON [dbo].[Ranking]([Movie_objMovie_Id] ASC);


    CREATE TABLE [dbo].[MoviesCollection] (
    [Moviescollection_Id] INT            IDENTITY (1, 1) NOT NULL,
    [Movie_Name]          NVARCHAR (MAX) NULL,
    [India]               NVARCHAR (MAX) NULL,
    [Canada]              NVARCHAR (MAX) NULL,
    [Australia]           NVARCHAR (MAX) NULL,
    [Movie_ID]            INT            NOT NULL,
    [Movie_objMovie_Id]   INT            NULL,
    CONSTRAINT [PK_MoviesCollection] PRIMARY KEY CLUSTERED ([Moviescollection_Id] ASC),
    CONSTRAINT [FK_MoviesCollection_Movies_Movie_objMovie_Id] FOREIGN KEY ([Movie_objMovie_Id]) REFERENCES [dbo].[Movies] ([Movie_Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_MoviesCollection_Movie_objMovie_Id]
    ON [dbo].[MoviesCollection]([Movie_objMovie_Id] ASC);


    CREATE TABLE [dbo].[Movies] (
    [Movie_Id]      INT            IDENTITY (1, 1) NOT NULL,
    [Movie_Name]    NVARCHAR (MAX) NULL,
    [Director_Name] NVARCHAR (MAX) NULL,
    [Actor_Name]    NVARCHAR (MAX) NULL,
    [Actress_Name]  NVARCHAR (MAX) NULL,
    [Release_Date]  DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED ([Movie_Id] ASC)
);


CREATE TABLE [dbo].[__EFMigrationsHistory] (
    [MigrationId]    NVARCHAR (150) NOT NULL,
    [ProductVersion] NVARCHAR (32)  NOT NULL,
    CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED ([MigrationId] ASC)
);


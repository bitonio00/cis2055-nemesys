CREATE TABLE [dbo].[Reports] (
    [ReportId]          INT            IDENTITY (1, 1) NOT NULL,
    [CreationDate]      DATETIME2 (7)  NOT NULL,
    [ProblemDate]       DATETIME2 (7)  NOT NULL,
    [Type]              NVARCHAR (MAX) NULL,
    [Description]       NVARCHAR (MAX) NULL,
    [Status]            NVARCHAR (MAX) NULL,
    [LongitudeLocation] FLOAT (53)     NOT NULL,
    [LatitudeLocation]  FLOAT (53)     NOT NULL,
    [UpVote]            INT            NOT NULL,
    [ReporterInfo]      NVARCHAR (MAX) NULL,
    [ReporterId]        INT            NULL,
    CONSTRAINT [PK_Reports] PRIMARY KEY CLUSTERED ([ReportId] ASC),
    CONSTRAINT [FK_Reports_Reporters_ReporterId] FOREIGN KEY ([ReporterId]) REFERENCES [dbo].[Reporters] ([ReporterId])
);


GO
CREATE NONCLUSTERED INDEX [IX_Reports_ReporterId]
    ON [dbo].[Reports]([ReporterId] ASC);


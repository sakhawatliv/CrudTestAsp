CREATE TABLE [dbo].[Department] (
    [Id]             INT        IDENTITY (1, 1) NOT NULL,
    [DepartmentName] NCHAR (10) NULL,
    [Code]           NCHAR (10) NULL,
    CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED ([Id] ASC)
);


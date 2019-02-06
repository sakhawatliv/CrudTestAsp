CREATE TABLE [dbo].[Student] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         VARBINARY (50) NULL,
    [Email]        VARBINARY (50) NULL,
    [DepartmentId] INT            NOT NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Student_Department] FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Department] ([Id])
);


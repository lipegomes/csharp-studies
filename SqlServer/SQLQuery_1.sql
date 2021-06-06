/* Create database */
CREATE DATABASE [Curso];

/* Delete database */
DROP DATABASE [Curso];

/* Use database */
USE [master];

/* Delete database */
DROP DATABASE [Curso];

/* Kill process and Delete database */
DECLARE @kill varchar(8000) = '';
SELECT @kill = @kill + 'kill' + CONVERT(varchar(5), session_id)
FROM sys.dm_exec_sessions
WHERE database_id = db_id('Curso')
EXEC(@kill);

DROP DATABASE [Curso];

/* Create database */
CREATE DATABASE [Curso];

/* Use database */
USE [Curso];

CREATE TABLE [Aluno] (
    [Id] INT,
    [Nome] NVARCHAR(80),
    [Nascimento] DATETIME, 
    [Active] BIT,
)
GO

/* Adds the Document Column to the Aluno table */
ALTER TABLE [Aluno]
    ADD [Document] NVARCHAR(11);

/* Removes the Document Column to the Aluno table */
ALTER TABLE [Aluno]
    DROP COLUMN [Document];

/* Adds the Document Column to the Aluno table */
ALTER TABLE [Aluno]
    ADD [Document] NVARCHAR(11);

ALTER TABLE [Aluno]
    ALTER COLUMN [Document] CHAR(11);

DROP TABLE [Aluno];

/* Constraints - Not Null */
CREATE TABLE [Aluno] (
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Nascimento] DATETIME NULL,
    [Active] BIT DEFAULT(0),
)
GO

ALTER TABLE [Aluno]
    ALTER COLUMN [Active] BIT NOT NULL;

/* Constraints - Unique */
ALTER TABLE [Aluno]
    ADD [Email] NVARCHAR(180) NOT NULL UNIQUE ;

/* Primary Key */
ALTER TABLE [Aluno]
    ADD CONSTRAINT [PK_Aluno] PRIMARY KEY ([Id]);

/* Composite Key */

DROP TABLE [Aluno];

CREATE TABLE [Aluno] (
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL,
    [Nascimento] DATETIME NULL,
    [Active] BIT DEFAULT(0),

    CONSTRAINT [PK_Aluno] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_Aluno_Email] UNIQUE([Email]),
)
GO

CREATE TABLE [Curso] (
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [CategoriaId] INT NOT NULL,

    CONSTRAINT [PK_Curso] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Curso_Categoria] FOREIGN KEY([CategoriaId])
        REFERENCES [Categoria](Id)
)
GO

CREATE TABLE [ProgressoCurso] (
    [AlunoId] INT NOT NULL,
    [CursoId] INT NOT NULL,
    [Progresso] INT NOT NULL,
    [UltimaAtualizacao] DATETIME NOT NULL DEFAULT(GETDATE()),

    CONSTRAINT PK_ProgessoCurso PRIMARY KEY([AlunoId], [CursoId])
)
GO

CREATE TABLE [Categoria] (
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,

    CONSTRAINT [PK_Categoria] PRIMARY KEY([Id])
);

DROP TABLE [Categoria];

/* Indices */
CREATE INDEX [IX_Aluno_Email] ON [ALUNO] ([Email]);

DROP INDEX [IX_Aluno_Email] ON [ALUNO];

/* Identity (Auto Increment) */
DROP TABLE [Curso];

CREATE TABLE [Curso] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Nome] NVARCHAR(80) NOT NULL,
    [CategoriaId] INT NOT NULL,

    CONSTRAINT [PK_Curso] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Curso_Categoria] FOREIGN KEY([CategoriaId])
        REFERENCES [Categoria](Id)
)
GO

/* Insert */
USE [master];

DROP DATABASE [Curso];

CREATE DATABASE [Cursos];

USE [Cursos];

CREATE TABLE [Categoria] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Nome] NVARCHAR(80) NOT NULL,

    CONSTRAINT [PK_Categoria] PRIMARY KEY([Id])
)
GO

CREATE TABLE [Curso] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Nome] NVARCHAR(80) NOT NULL,
    [CategoriaId] INT NOT NULL,

    CONSTRAINT [PK_Curso] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Curso_Categoria] FOREIGN KEY([CategoriaId])
        REFERENCES [Categoria](Id)
)
GO

INSERT INTO [Categoria]([Nome]) VALUES('Backend');
INSERT INTO [Categoria]([Nome]) VALUES('Frontend');
INSERT INTO [Categoria]([Nome]) VALUES('Mobile');

INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Fundamentos de OOP', 1);
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Fundamentos de C#', 1);
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Angular', 2);
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Flutter', 3);

INSERT INTO [Curso] VALUES('Flutter e SQLite', 3);
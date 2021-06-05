/* Create database*/
CREATE DATABASE [Curso];

/* Delete database */
DROP DATABASE [Curso];

/* Use database */
USE [master];

/* Delete database */
DROP DATABASE [Curso];

/* Kill process and Delete database*/
DECLARE @kill varchar(8000) = '';
SELECT @kill = @kill + 'kill' + CONVERT(varchar(5), session_id)
FROM sys.dm_exec_sessions
WHERE database_id = db_id('Curso')
EXEC(@kill);
DROP DATABASE [Curso];

/* Create database*/
CREATE DATABASE [Curso];

/* Use database */
USE [Curso];

CREATE TABLE [Aluno](
    [Id] INT,
    [Nome] NVARCHAR(80),
    [Nascimento] DATETIME, 
    [Active] BIT,
)
GO
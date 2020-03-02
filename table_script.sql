
CREATE DATABASE Students;

USE [Students]
CREATE TABLE [dbo].[SignIn] (
    [username] VARCHAR (20) NOT NULL,
    [password] VARCHAR (50) NOT NULL
);


INSERT INTO [dbo].[SignIn] ([username], [password])
VALUES ('Admin', 'admin'),
	   ('User', 'user');


CREATE TABLE [dbo].[Students] (
    [Firstname]    VARCHAR (20) NULL,
    [Surname]      VARCHAR (20) NULL,
    [Email]        VARCHAR (20) NULL,
    [Phone]        VARCHAR (20) NULL,
    [AddressLine1] VARCHAR (50) NULL,
    [AddressLine2] VARCHAR (50) NULL,
    [City]         VARCHAR (20) NULL,
    [County]       VARCHAR (20) NULL,
    [Level]        VARCHAR (20) NULL,
    [Course]       VARCHAR (20) NULL,
    [StudentId]    INT          NOT NULL
);
GO

INSERT INTO [dbo].[Students]([Firstname], [Surname], [Email], [Phone], [AddressLine1], [AddressLine2], [City], [County], [Level], [Course], [StudentId])
VALUES ('Niall', 'Kane', 'niall@gmail.com', '086-111-1111', '3 Woodland', 'Park', 'Red Road', 'Dublin', 'Postgraduate', 'Computing', 123456),
       ('Tom', 'Jones', 'tom.jones@gmail.com', '087-222-2222', '8 Grassland', 'Street', 'Water Road', 'Galway', 'Undergraduate', 'Arts', 654321);
GO

USE [Students]
GO

/****** Object: SqlProcedure [dbo].[sp_Login] Script Date: 02/03/2020 19:41:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_Login
	@username VARCHAR(20),
	@password VARCHAR(20)
AS
	SELECT * FROM SignIn WHERE username=@username AND password=@password
RETURN 0
GO

USE [Students]
GO

/****** Object: SqlProcedure [dbo].[sp_InsertStudent] Script Date: 02/03/2020 19:41:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_InsertStudent
	@firstName VARCHAR(20), @surname VARCHAR(20), @email VARCHAR(20), @phone VARCHAR(20), 
	@address1 VARCHAR(20), @address2 VARCHAR(20), @city VARCHAR(20), @county VARCHAR(20), 
	@level VARCHAR(20), @course VARCHAR(20), @studentId INT
AS
	INSERT INTO Students(FirstName, Surname, Email, Phone, AddressLine1, AddressLine2, City, County, Level, Course, StudentId) VALUES(@firstName, @surname, @email, @phone, @address1, @address2, @city, @county, @level, @course, @studentId)
RETURN 0
GO

USE [Students]
GO

/****** Object: SqlProcedure [dbo].[sp_UpdateStudent] Script Date: 02/03/2020 19:41:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_UpdateStudent
	@email VARCHAR(20), @phone VARCHAR(20), @address1 VARCHAR(20), @address2 VARCHAR(20), 
	@city VARCHAR(20), @county VARCHAR(20), @level VARCHAR(20), @studentId INT 
AS
	UPDATE Students SET Email=@email, Phone=@phone, AddressLine1=@address1, AddressLine2=@address2, City=@city, County=@county, Level=@level WHERE StudentId=@studentId
RETURN 0
GO

USE [Students]
GO

/****** Object: SqlProcedure [dbo].[sp_DeleteStudent] Script Date: 02/03/2020 19:42:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_DeleteStudent
	@studentId INT
AS
	DELETE FROM Students WHERE StudentId=@studentId
RETURN 0
GO

USE [Students]
GO

/****** Object: SqlProcedure [dbo].[sp_StudentSearch] Script Date: 02/03/2020 19:42:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_StudentSearch
	@studentId int
AS
	SELECT * FROM Students WHERE StudentId=@studentId
RETURN 0
GO


CREATE TABLE [dbo].[AuditStudent] (
    [StudentId] INT          NULL,
    [Action]    VARCHAR (20) NULL,
    [Date]      DATETIME     NULL
);

GO

CREATE TRIGGER audit_trigger
       ON dbo.Students
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
       SET NOCOUNT ON;
 
       DECLARE @studentId INT
	   DECLARE @username VARCHAR(20)
       DECLARE @action VARCHAR(50)
 
       SELECT @studentId = INSERTED.StudentId  
       FROM INSERTED

	   SET @action = (CASE WHEN EXISTS(SELECT * FROM INSERTED)
                         AND EXISTS(SELECT * FROM DELETED)
                        THEN 'Student Updated'  -- Set Action to Updated.
                        WHEN EXISTS(SELECT * FROM INSERTED)
                        THEN 'Student Inserted'  -- Set Action to Insert.
                        WHEN EXISTS(SELECT * FROM DELETED)
                        THEN 'Student Deleted'  -- Set Action to Deleted.
                        ELSE NULL -- Skip. It may have been a "failed delete".   
                    END)

		IF @action = 'Student Deleted'
		BEGIN
			SELECT @studentId = deleted.StudentId   
			FROM deleted
			INSERT INTO dbo.AuditStudent
			VALUES(@studentId, @action, GETDATE())
		END
		ELSE
		BEGIN
			INSERT INTO dbo.AuditStudent
			VALUES(@studentId, @action, GETDATE())
		END	
END
GO








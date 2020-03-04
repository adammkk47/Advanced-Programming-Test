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
    [StudentId]    INT  PRIMARY KEY   NOT NULL
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
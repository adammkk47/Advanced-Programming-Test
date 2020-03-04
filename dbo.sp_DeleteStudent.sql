CREATE PROCEDURE sp_DeleteStudent
	@studentId INT
AS
	DELETE FROM Students WHERE StudentId=@studentId
RETURN 0
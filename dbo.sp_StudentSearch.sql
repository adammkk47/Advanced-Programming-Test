CREATE PROCEDURE sp_StudentSearch
	@studentId int
AS
	SELECT * FROM Students WHERE StudentId=@studentId
RETURN 0
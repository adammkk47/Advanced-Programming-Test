CREATE PROCEDURE sp_InsertStudent
	@firstName VARCHAR(20), @surname VARCHAR(20), @email VARCHAR(20), @phone VARCHAR(20), 
	@address1 VARCHAR(20), @address2 VARCHAR(20), @city VARCHAR(20), @county VARCHAR(20), 
	@level VARCHAR(20), @course VARCHAR(20), @studentId INT
AS
	INSERT INTO Students(FirstName, Surname, Email, Phone, AddressLine1, AddressLine2, City, County, Level, Course, StudentId) VALUES(@firstName, @surname, @email, @phone, @address1, @address2, @city, @county, @level, @course, @studentId)
RETURN 0
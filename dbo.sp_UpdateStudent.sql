CREATE PROCEDURE sp_UpdateStudent
	@email VARCHAR(20), @phone VARCHAR(20), @address1 VARCHAR(20), @address2 VARCHAR(20), 
	@city VARCHAR(20), @county VARCHAR(20), @level VARCHAR(20), @studentId INT 
AS
	UPDATE Students SET Email=@email, Phone=@phone, AddressLine1=@address1, AddressLine2=@address2, City=@city, County=@county, Level=@level WHERE StudentId=@studentId
RETURN 0
CREATE PROCEDURE sp_Login
	@username VARCHAR(20),
	@password VARCHAR(20)
AS

OPEN SYMMETRIC KEY SymmetricKey1
DECRYPTION BY CERTIFICATE Certificate1;

SELECT *
FROM dbo.SignIn
WHERE username=@username AND CONVERT(varchar, DecryptByKey(Password__encrypt))=@password
 
CLOSE SYMMETRIC KEY SymmetricKey1;
GO

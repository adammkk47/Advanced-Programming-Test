USE master;
GO
SELECT *
FROM sys.symmetric_keys
WHERE name = '##MS_ServiceMasterKey##';
GO

-- Create database Key
USE Students;
GO
CREATE MASTER KEY ENCRYPTION BY PASSWORD = '.tkM~`7gSbp5e"AKR/&>W)';
GO

-- Create self signed certificate
USE Students;
GO
CREATE CERTIFICATE Certificate1
WITH SUBJECT = 'Protect Data';
GO

-- Create symmetric Key
USE Students;
GO
CREATE SYMMETRIC KEY SymmetricKey1 
 WITH ALGORITHM = AES_128 
 ENCRYPTION BY CERTIFICATE Certificate1;
GO

USE Students;
GO
ALTER TABLE SignIn
ADD Password__encrypt varbinary(MAX) NULL
GO

-- Populating encrypted data into new column
USE Students;
GO
-- Opens the symmetric key for use
OPEN SYMMETRIC KEY SymmetricKey1
DECRYPTION BY CERTIFICATE Certificate1;
GO
UPDATE SignIn
SET Password__encrypt = EncryptByKey (Key_GUID('SymmetricKey1'),password)
FROM dbo.SignIn;
GO
-- Closes the symmetric key
CLOSE SYMMETRIC KEY SymmetricKey1;
GO

USE Students;
GO
ALTER TABLE SignIn
DROP COLUMN password;
GO

USE Students;
GO
OPEN SYMMETRIC KEY SymmetricKey1
DECRYPTION BY CERTIFICATE Certificate1;
--GO
-- Now list the original ID, the encrypted ID 
SELECT username, CONVERT(varchar, DecryptByKey(Password__encrypt)) --AS 'Encrypted Credit Card Number',
 --AS 'Decrypted Credit Card Number'
FROM dbo.SignIn;
 
 -- Close the symmetric key
CLOSE SYMMETRIC KEY SymmetricKey1;
GO
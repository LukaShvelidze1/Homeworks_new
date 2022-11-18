USE [HomeWorkWeek15]

--Students

--1
SELECT * FROM Students WHERE DoB LIKE '1990%'

--2
SELECT Firstname, Lastname, Dob FROM Students WHERE Country = 'Georgia' OR Country = 'Libya'

--3

INSERT INTO [dbo].[Students]
(Firstname, Lastname, DoB, Email)
	VALUES
	(N'Bruce', N'Wayne', '1980-01-27', 'Bruce@batman.com')

--4

SELECT TOP 5 Firstname, MiddleTest
FROM Students ORDER BY MiddleTest DESC

--5
DELETE FROM Students
OUTPUT deleted.Firstname
WHERE FinalTest = '19' --უბანძესი სინტაქსი :)))))

--6
UPDATE Students
SET FinalTest = '0' 
WHERE MiddleTest = '1'


--Persons

--1
SELECT * FROM Persons WHERE PrivateId LIKE '163_%' 

--2
SELECT * FROM Persons WHERE Lastname LIKE City

--3

SELECT * FROM Persons WHERE Country IN ('Canada') OR Country IN ('Monaco')

--4

SELECT Firstname, Lastname, PersonsID FROM Persons WHERE Email IS NULL

--5

SELECT * FROM Persons WHERE Salary BETWEEN 1000 AND 3000
AND (Country = 'Spain' OR Country = 'Turkey')
 
--6
SELECT WorkPlace FROM Persons WHERE WorkPlace LIKE '%LLC' OR WorkPlace LIKE '%PC' OR WorkPlace LIKE '%LLP'

--8
SELECT * FROM Persons WHERE PINcode LIKE '%51'

--9
SELECT Country, AVG(Salary) FROM Persons
GROUP BY Country

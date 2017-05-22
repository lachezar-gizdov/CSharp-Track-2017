-- Task 4
use TelerikAcademy
SELECT * FROM Departments

-- Task 5
use TelerikAcademy
SELECT Name FROM Departments

-- Task 6
use TelerikAcademy
SELECT FirstName, LastName, Salary FROM Employees

-- Task 7
use TelerikAcademy
SELECT FirstName + ' ' + LastName AS [Full Name] FROM Employees

-- Task 8
use TelerikAcademy
SELECT FirstName + '.' + LastName + '@telerik.com' AS [Full Email Address] FROM Employees

-- Task 9
use TelerikAcademy
SELECT DISTINCT Salary FROM Employees

-- Task 10
use TelerikAcademy
SELECT * FROM Employees
WHERE JobTitle = 'Sales Representative'

-- Task 11
use TelerikAcademy
SELECT * FROM Employees
WHERE FirstName LIKE 'SA%'

-- Task 12
use TelerikAcademy
SELECT * FROM Employees
WHERE LastName LIKE '%ei%'

-- Task 13
use TelerikAcademy
SELECT * FROM Employees
WHERE Salary BETWEEN 20000 AND 30000

-- Task 14
use TelerikAcademy
SELECT * FROM Employees
WHERE Salary IN (25000, 14000, 12500, 23600)

-- Task 15
use TelerikAcademy
SELECT * FROM Employees
WHERE ManagerID IS NULL

-- Task 16
use TelerikAcademy
SELECT * FROM Employees
WHERE Salary >= 5000
ORDER BY Salary DESC

-- Task 17
USE TelerikAcademy
SELECT TOP (5) *
  FROM Employees
ORDER BY Salary DESC

-- Task 20
USE TelerikAcademy
SELECT * FROM Employees e
INNER JOIN Employees m
ON e.EmployeeID = m.ManagerID

-- Task 21
USE TelerikAcademy
SELECT * FROM Employees e
INNER JOIN Employees m
ON e.EmployeeID = m.ManagerID
INNER JOIN Addresses a
ON e.AddressID = a.AddressID

-- Task 22
USE TelerikAcademy
SELECT Name FROM Departments
UNION ALL
SELECT Name FROM Towns

-- Task 24
USE TelerikAcademy
SELECT * FROM Employees
JOIN Departments
ON Employees.EmployeeID = Departments.DepartmentID
WHERE Departments.Name = 'Sales' OR Departments.Name = 'Finance'
AND Employees.HireDate BETWEEN '1995' AND '2005'
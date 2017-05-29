--Task 1
SELECT FirstName +' ' + LastName AS [Full Name], Salary
FROM Employees
WHERE Employees.Salary = (
SELECT MIN(Salary)
FROM Employees)

--Task 2
SELECT FirstName +' ' + LastName AS [Full Name], Salary
FROM Employees
WHERE Employees.Salary < (
SELECT MIN(Salary + (Salary * 0.1))
FROM Employees)

--Task 3
SELECT FirstName +' ' + LastName AS [Full Name], d.Name, Salary
FROM Employees e
    JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE Salary = (
SELECT MIN(Salary)
FROM Employees
WHERE DepartmentId = e.DepartmentID
)

--Task 4
SELECT AVG(Salary) AS [Average Salary]
FROM Employees
WHERE DepartmentID = 1

--Task 5
SELECT AVG(Salary) AS [Average Salary], d.Name AS [Department Name]
FROM Employees e
    JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
GROUP BY d.Name

--Task 6
SELECT count(*) AS [Employees in Sales]
FROM Employees e
    JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--Task 7
SELECT COUNT(*) AS [Employees with manager]
FROM Employees
WHERE ManagerID IS NOT NULL

--Task 8
SELECT COUNT(*) AS [Managers]
FROM Employees
WHERE ManagerID IS NULL

--Task 9
SELECT d.Name AS [Department Name], AVG(Salary) AS [AVG Salary]
FROM Employees e
    JOIN Departments d
    ON d.DepartmentID = e.DepartmentID
GROUP BY d.Name

--Task 10
SELECT COUNT(*) AS [Employees Count], t.Name AS [Town], d.Name AS [Department Name]
FROM Employees e
    JOIN Departments d
    ON d.DepartmentID = e.DepartmentID
    JOIN Addresses ad
    ON e.AddressID = ad.AddressID
    JOIN Towns t
    ON ad.TownID = t.TownID
GROUP BY d.Name, t.Name

--Task 11 //Need fixing I guess??
SELECT m.FirstName + ' ' + m.LastName AS [Full Name], COUNT(*) AS [Number of Employees]
FROM Employees e
    JOIN Employees m
    ON e.ManagerID = m.ManagerID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(*) = 5

--Task 12
SELECT e.FirstName + ' ' + e.LastName AS [Employee Full Name],
    COALESCE(m.FirstName + ' ' + m.LastName, 'no manager') AS [Manager Name]
FROM Employees e
    LEFT OUTER JOIN Employees m
    ON e.ManagerID = m.EmployeeID

--Task 13
SELECT e.FirstName + ' ' + e.LastName AS [Employee Full Name]
FROM Employees e
WHERE LEN(e.LastName) = 5

--Task 14
SELECT FORMAT(GETDATE(),'d.MM.yyyy hh:mm:ss:ff') AS [Current Date and Time]

--Task 15
CREATE TABLE Users
(
    Id INT IDENTITY PRIMARY KEY,
    UserName NVARCHAR(20) UNIQUE NOT NULL,
    UserPassword NVARCHAR(100) NOT NULL CHECK( LEN(UserPassword) >= 5),
    FullName NVARCHAR(50),
    LastLoginTime DATETIME
)

--Task 16
INSERT INTO Users
    (UserName, UserPassword, FullName, LastLoginTime)
VALUES
    ('User1', 'password1', 'user1 fullname', NULL)

INSERT INTO Users
    (UserName, UserPassword, FullName, LastLoginTime)
VALUES
    ('User2', 'password2', 'user2 fullname', GETDATE())

SELECT *
FROM Users
WHERE FORMAT(Users.LastLoginTime, 'd.MM.yyyy') = FORMAT(GETDATE(), 'd.MM.yyyy')

--Task 17
CREATE TABLE Groups
(
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(20) UNIQUE
)

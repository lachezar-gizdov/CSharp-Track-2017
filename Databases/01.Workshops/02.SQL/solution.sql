--Task 1 
CREATE TABLE Cities 
( 
    CityId INT IDENTITY PRIMARY KEY, 
    Name NVARCHAR(50) 
)

--Task 2
INSERT INTO Cities (Name)

SELECT DISTINCT City FROM Employees
UNION
SELECT DISTINCT City FROM Suppliers
UNION
SELECT DISTINCT City FROM Customers

--Task 3
ALTER TABLE Employees
ADD CityId INT FOREIGN KEY REFERENCES Cities(CityId)

ALTER TABLE Suppliers
ADD CityId INT FOREIGN KEY REFERENCES Cities(CityId)

ALTER TABLE Customers
ADD CityId INT FOREIGN KEY REFERENCES Cities(CityId)

--Task 4

UPDATE Employees
SET Employees.CityId = (SELECT Cities.CityId
FROM Cities
WHERE Cities.Name = Employees.City)

UPDATE Suppliers
SET Suppliers.CityId = (SELECT Cities.CityId
FROM Cities
WHERE Cities.Name = Suppliers.City)

UPDATE Customers
SET Customers.CityId = (SELECT Cities.CityId
FROM Cities
WHERE Cities.Name = Customers.City)

--Task 5
ALTER TABLE Cities
ADD UNIQUE (Name)

--Task 6
INSERT Cities (Name)
SELECT DISTINCT ShipCity FROM Orders
WHERE NOT EXISTS 
(
	SELECT 1 FROM Cities 
	WHERE Name = ShipCity
)

--Task 7
ALTER TABLE Orders
ADD CityId INT FOREIGN KEY REFERENCES Cities(CityId)

--Task 8
EXEC sp_rename 'Orders.CityId', 'ShipCityId'


--Task 9
UPDATE Orders
SET Orders.ShipCityId = (SELECT Cities.CityId
FROM Cities
WHERE Cities.Name = Orders.ShipCity)

--Task 10
CREATE TABLE Countries(
	CountryId INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50) UNIQUE
)

--Task 11
ALTER TABLE Orders
DROP COLUMN ShipCity


--Task 12
ALTER TABLE Cities
ADD CountryId INT FOREIGN KEY REFERENCES Countries(CountryId)

--Task 13
INSERT INTO Countries(Name)

SELECT DISTINCT Country FROM Employees
UNION
SELECT DISTINCT Country FROM Suppliers
UNION
SELECT DISTINCT Country FROM Customers
UNION
SELECT DISTINCT ShipCountry FROM Orders

--Task 14
UPDATE Cities
SET Cities.CountryId = ( SELECT [Countries ].CountryId
FROM [Countries ]
WHERE [Countries ].Name = Cities.Name)

--Task 15
ALTER TABLE Employees
DROP COLUMN City

ALTER TABLE Suppliers
DROP COLUMN City
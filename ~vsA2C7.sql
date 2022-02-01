--------------------------ДОМАШКА----------------------------

----------------------ЗАДАНИЕ №1-----------------------------
--Вывести всю информацию из таблицы Sales.Customer 
-------------------------------------------------------------
use [AdventureWorks2019]
Select * 
From Sales.Customer

GO

----------------------ЗАДАНИЕ №2-----------------------------
--Вывести всю информацию из таблицы Sales.Store отсортированную 
--по Name в алфавитном порядке
-------------------------------------------------------------
use [AdventureWorks2019]
Select * 
From Sales.Store
Order by Name

GO

----------------------ЗАДАНИЕ №3-----------------------------
--Вывести из таблицы HumanResources.Employee всю информацию
--о десяти сотрудниках, которые родились позже 1989-09-28
-------------------------------------------------------------
use [AdventureWorks2019]
Select * 
From HumanResources.Employee
where BirthDate > '1989-09-28'

GO

----------------------ЗАДАНИЕ №4-----------------------------
--Вывести из таблицы HumanResources.Employee сотрудников
--у которых последний символ LoginID является 0.
--Вывести только NationalIDNumber, LoginID, JobTitle.
--Данные должны быть отсортированы по JobTitle по убиванию
-------------------------------------------------------------
use [AdventureWorks2019]
Select NationalIDNumber, LoginID, JobTitle
From HumanResources.Employee
Where LoginID like '%0'
order by JobTitle desc

GO

----------------------ЗАДАНИЕ №5-----------------------------
--Вывести из таблицы Person.Person всю информацию о записях, которые были 
--обновлены в 2008 году (ModifiedDate) и MiddleName содержит
--значение и Title не содержит значение 
-------------------------------------------------------------
use [AdventureWorks2019]
Select * 
From Person.Person
where 
(ModifiedDate BETWEEN '2008' and '2009')
GO

----------------------ЗАДАНИЕ №6-----------------------------
--Вывести название отдела (HumanResources.Department.Name) БЕЗ повторений
--в которых есть сотрудники
--Использовать таблицы HumanResources.EmployeeDepartmentHistory и HumanResources.Department

use [AdventureWorks2019]
SELECT DISTINCT hrd.DepartmentID, hrd.Name
FROM HumanResources.EmployeeDepartmentHistory AS hredh
INNER JOIN HumanResources.Department AS hrd ON hredh.DepartmentID=hrd.DepartmentID

GO

------------------------ЗАДАНИЕ №7-----------------------------
----Сгрупировать данные из таблицы Sales.SalesPerson по TerritoryID
----и вывести сумму CommissionPct, если она больше 0

use [AdventureWorks2019]
SELECT TerritoryID, SUM(CommissionPct)
FROM  Sales.SalesPerson
GROUP BY TerritoryID
HAVING SUM(CommissionPct) > 0

GO

---------------------ЗАДАНИЕ №10-----------------------------
--Вывести всю информацию о сотрудниках (HumanResources.Employee) и 
--их заказах (Purchasing.PurchaseOrderHeader). ЕСЛИ У СОТРУДНИКА НЕТ
--ЗАКАЗОВ ОН ДОЛЖЕН БЫТЬ ВЫВЕДЕН ТОЖЕ!!!

use [AdventureWorks2019]
SELECT *
FROM HumanResources.Employee
LEFT JOIN Purchasing.PurchaseOrderHeader ON PurchaseOrderHeader.EmployeeID = HumanResources.Employee.BusinessEntityID
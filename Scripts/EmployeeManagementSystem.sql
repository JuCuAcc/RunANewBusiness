--Use master 
--IF DB_ID('EmployeeManagementSystem') IS NOT NULL
--DROP Database EmployeeManagementSystem;
--CREATE Database EmployeeManagementSystem;
--GO

Use EmployeeManagementSystem;
GO

CREATE Table Employees (
	EmployeeID		int PRIMARY KEY IDENTITY,
	FullName		nvarchar(255) NOT NULL,
	DateOfBirth		date,
	EmployeeType	int NOT NULL, --permanent, contractual, part-time
	JoiningDate		date DEFAULT(GETDATE()),
	BasicSalary		decimal(18,2) DEFAULT(0.00),
	TotalSalary		decimal(18,2) DEFAULT(0.00),
	[Status]		varchar(255),
	Remarks			varchar(255)
);
GO


INSERT Employees
	VALUES('Jamilur','2000/10/10',1,'2005/12/01',35000,35000,'Paid', 'Not Applicable'),
			('Forid','2000/10/10',1,'2005/12/01',16000,16000,'Paid', 'Not Applicable'),
				('Shohagh','2000/10/10',1,'2005/12/01',16000,16000,'Paid', 'Not Applicable'),
					('Romzan','2000/10/10',2,'2005/12/01',12000,12000,'Paid', 'Not Applicable'),
						('Sweet','2000/10/10',3,'2005/12/01',700,21000,'Paid', 'Not Applicable'),
							('Rezaul','2000/10/10',3,'2005/12/01',700,21000,'Paid', 'Not Applicable');
GO

SELECT * FROM Employees;
GO

-- For Report
--DROP PROC sp_GetTotalPayoutsPerEmployee
CREATE PROC sp_GetTotalPayoutsPerEmployee
AS
BEGIN
    SELECT 
        EmployeeID,
        FullName,
        BasicSalary,  
        SUM(TotalSalary) AS TotalPayouts
    FROM 
        Employees
    GROUP BY 
        EmployeeID, FullName, BasicSalary;  
END;
GO


CREATE PROC sp_GetTotalPayoutsPerEmployeeType
AS
BEGIN
    SELECT 
        EmployeeType,
        SUM(TotalSalary) AS TotalPayouts
    FROM 
        Employees
    GROUP BY 
        EmployeeType;
END;
GO

EXEC sp_GetTotalPayoutsPerEmployee;
EXEC sp_GetTotalPayoutsPerEmployeeType;
GO

--Views
CREATE VIEW vw_TotalPayoutsPerEmployee AS
SELECT 
    EmployeeID,
    FullName,
    BasicSalary,
    SUM(TotalSalary) AS TotalPayouts
FROM 
    Employees
GROUP BY 
    EmployeeID, FullName, BasicSalary;
GO

CREATE VIEW vw_TotalPayoutsPerEmployeeType AS
SELECT 
    EmployeeType,
    SUM(TotalSalary) AS TotalPayouts
FROM 
    Employees
GROUP BY 
    EmployeeType;
GO

SELECT * FROM vw_TotalPayoutsPerEmployee;
SELECT * FROM vw_TotalPayoutsPerEmployeeType;
GO
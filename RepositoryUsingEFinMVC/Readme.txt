Reffered from link 
https://dotnettutorials.net/lesson/repository-design-pattern-csharp/


Please use the below SQL script to create and populate the Employee table with the required data that we 
are going to use in our application.

-- Create EmployeeDB database
CREATE DATABASE EmployeeDB
GO

USE EmployeeDB
GO

-- Create Employee Table
CREATE TABLE Employee
(
  EmployeeID INT PRIMARY KEY IDENTITY(1,1),
  Name VARCHAR(100),
  Gender VARCHAR(100),
  Salary INT,
  Dept VARCHAR(50)
)
GO

-- Populate some test data into Employee table
INSERT INTO Employee VALUES('Pranaya', 'Male', 10000, 'IT' )
INSERT INTO Employee VALUES('Anurag', 'Male', 15000, 'HR' )
INSERT INTO Employee VALUES('Priyanka', 'Female', 22000, 'HR' )
INSERT INTO Employee VALUES('Sambit', 'Male', 20000, 'IT' )
INSERT INTO Employee VALUES('Preety', 'Female', 25000, 'IT' )
INSERT INTO Employee VALUES('Hina', 'Female', 20000, 'HR' )
GO

SELECT * FROM Employee
GO
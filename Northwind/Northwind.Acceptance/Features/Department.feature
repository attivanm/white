Feature: Department
	Feature description...

@Department
Scenario: Create Department
	When I create a department
	Then it should appear in the department grid 

@Department
Scenario: Create several Departments
	When I create a several departments
	Then they should appear in the department grid

@Employee
Scenario: Create an Employee
	Given I have a department
	When I create an employee using the following values:
	| Field | Value |
	|       |       |
	|       |       |
	|       |       |
	Then it should appear in the employee grid

@Employee
Scenario: Create several Employees
	Given I have a department
	When I create several employees using the following values:
	| First Name | Last Name | Employee Type | About | Department |
	|            |           |               |       |            |
	|            |           |               |       |            |
	|            |           |               |       |            | 
	Then they should appear in the employee grid
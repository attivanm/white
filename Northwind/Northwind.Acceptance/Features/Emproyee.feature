Feature: Emproyee
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Employee
Scenario: Create an Employee
	Given I have a department
	When I create an employee using the following values:
         | Field            | Value            |
         | First Name       | Gonzalo          |
         | Last Name        | Alba             |
         | Employee Type    | Fulltime         |
         | About            | I'm automation   |
         | Departament Name | My departament 1 |
	Then it should appear in the employee grid

@Employee
Scenario: Create several Employees
	Given I have a department
	When I create several employees using the following values:
         | First Name | Last Name | Employee Type | About      | Departament Name |
         | Gonzalo    | alba      | fulltime      | automation | My departament 1 |
         | employee   | alba2     | fulltime      | automation | My departament 2 |
         | employee2  | alba3     | fulltime      | tester     | My departament 3 |
	Then it should appear in the employee grid

	@Employee
Scenario: Create an Employee another scenario
	Given I have a department using the following values:
	| Field | Value                 |
	| Name  | InfoManager.DeptoName |
	When I create an employee using the following values:
         | Field            | Value                 |
         | First Name       | Gonzalo               |
         | Last Name        | Alba                  |
         | Employee Type    | Fulltime              |
         | About            | I'm automation        |
         | Departament Name | InfoManager.DeptoName |
	Then it should appear in the employee grid

		@Employee
Scenario: Create an Employee another scenario2 
	Given I have the following Department created:
	| name                   |
	| InfoManager.DeptoName&1 |
	| InfoManager.DeptoName&2 |
	| InfoManager.DeptoName&3 |

	When I create several employees using the following values:
	| First Name | Last Name | Employee Type | About      | Departament Name       |
	| Gonzalo    | alba      | fulltime      | automation | InfoManager.DeptoName&1 |
	| employee   | alba2     | fulltime      | automation | InfoManager.DeptoName&2 |
	| employee2  | alba3     | fulltime      | tester     | InfoManager.DeptoName&3 |
	Then it should appear in the employee grid
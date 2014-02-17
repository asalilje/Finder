Feature: User Registration
	In order to access the member area
	as a potential new user
	I want to register an account

	Scenario Outline: Password strength indicator
	Given I am on the registration page
	When I enter a password of <password>
	Then the strength indicator should read <strength>

	Examples:
	| password  | strength |
	| Pass      | Dålig    |
	| Password  | Hyfsad   |
	| Password1 | Suverän  |

	
	 
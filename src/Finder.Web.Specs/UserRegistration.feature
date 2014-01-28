Feature: User Registration
	In order to get access to the bacon info
	As a potential new user
	I want to create an account


Scenario Outline: Password strength indicator
Given I'm on the registration page
When I enter a password of <password>
Then the password strength indicator should read <strength>

Examples: 
| password  | strength |
| pass      | Dålig    |
| Password  | Hyfsad   |
| Password1! | Suverän  |

Feature: New User Registration
	In order to get access to the member-only features
	As a potential new user
	I want to create an account

Scenario: Password Strength Indicator
Given I'm on the registration page
When I enter a password of pwd
Then the password strength indicator should read Dålig

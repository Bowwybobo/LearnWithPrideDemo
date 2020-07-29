Feature: Registration
	In order to use Angularjs
	To carry out testing
	I need to register

@mytag
Scenario Outline: Registration
	Given I Navigate to "https://angularjs.realworld.io/#/register"
	When I enter a username "<username>"
	And I enter my email "<email>"
	And I create a password "<password>"
	And I click on sign up
	#Then I should be logged in with my username displayed


Examples:

| username  | email | password       |
| Bowwy     | Demo  | PasswordSecure |
| Bowwybobo | Bowwy | Olutosin87     |

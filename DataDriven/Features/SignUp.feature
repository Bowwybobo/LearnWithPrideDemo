Feature: SignUp
	In order to carry out test pracice on Angularjs
	I need to sign up for an account
	And Login

@mytag
Scenario: Sign Up
	Given I navigate to the website "https://angularjs.realworld.io/#/register"
	When I enter a username "MrNubesco"
	And I enter my email "Nubi"
	And I enter a password "Oluyemisi"
	And I click on sign up
	#Then I should be registered and logged in with my username displayed
	

Feature: Registration
	In order to use Amazon website
    I will need to register
	So that am able to make purchases

@mytag
Scenario:Registration 
	Given I navigate to Amazon website
	When I click on sign in
	And I click on create Amazon account
	And I enter my name
	And I enter my email address
	And I create a password
	And I re-enter my password
	And I click on create account
	#Then my account should be created

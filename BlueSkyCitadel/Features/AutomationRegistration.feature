Feature: AutomationRegistration
	In order to be eligible for internship
	I need to register to show my interest
	Before i can apply

@mytag
Scenario: Registration
	Given I Navigate to "https://blueskycitadel.com/automation-testing-form/"
	When I Enter a value in the single line text "Bowwy"
	And I Select a value from the select drop down
	And I Enter my email "Bowwybo"
	And I Enter a password "Ogede"
	And I Select multiple numbers from the multi select
	And I Choose a radio list
	And I Tick the checkbox
	And I Select a country
	And I Enter a date "12/31/2019"
	#And I Check the single check box
	And I Enter words in the paragraph text "Please i want to do internship"
	When I Click submit
	#Then I Should be registered

Feature: Google_UI


Scenario: Google Search
	Given user is on the Google search homepage
	When user searches for 'Test Automation' on google search
	Then a google search results with atleast '5' items is displayed



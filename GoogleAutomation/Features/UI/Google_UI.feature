Feature: Google_UI


Scenario: Search
	Given user is on the homepage
	When user search for 'Test Automation'
	Then a search results with atleast '5' items is displayed



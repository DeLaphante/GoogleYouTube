Feature: Youtube_UI


Scenario: Youtube Search
	Given user is on the Youtube homepage
	When user searches for 'Test Automation' on youtube search
	Then a youtube search results with atleast '5' items is displayed



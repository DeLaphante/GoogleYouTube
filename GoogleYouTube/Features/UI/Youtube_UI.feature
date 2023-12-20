Feature: YouTube_UI


Scenario: YouTube Search
	Given user is on the YouTube homepage
	When user searches for 'Test Automation' on YouTube search
	Then a YouTube search results with atleast '5' items is displayed



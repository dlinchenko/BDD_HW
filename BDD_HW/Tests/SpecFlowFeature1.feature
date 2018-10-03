Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I am on Rozetka main page
	When I enter search value Apple Iphone 7 and open firt details page
	And When I open details tab
	Then the result should be 120 on the screen

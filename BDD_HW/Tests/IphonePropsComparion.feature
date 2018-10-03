Feature: IphonePropsComparion


@mytag
Scenario: Compare Iphones props
	Given I am on Rozetka store page
	When I search for Apple Iphone 7 and I open first found item
	And I open characteristics tab
	Then the result should be 120 on the screen

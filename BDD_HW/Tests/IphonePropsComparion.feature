﻿Feature: IphonePropsComparion


@mytag
Scenario: Compare Iphones props and print similar to console
	Given I am on Rozetka store page
	When I get details of Apple IPhone 7
	And I get details of Apple IPhone 7 Plus
	Then their details are compared and similar are printed to console

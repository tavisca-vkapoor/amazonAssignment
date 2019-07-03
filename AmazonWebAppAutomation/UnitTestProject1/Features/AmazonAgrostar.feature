Feature: AmazonAgrostar
	In order to test amazon product checkout feature
	As a user 
	I want to place orders and place it for particular address

@mytag
Scenario: Placing the product IPhone X 64GB Silver for Agrostar Address
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

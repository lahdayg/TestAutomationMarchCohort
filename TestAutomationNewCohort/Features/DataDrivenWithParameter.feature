Feature: DataDrivenWithParameter

A short summary of the feature

@tag1
Scenario: Data Driven With Parameter
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign up
	#And I bought 2 pens
	And I enter my Username "LWP44"
	And I enter my Email "demo@example1.com"
	And I enter my password "PasswordSecure"
	When I click on the sign up button
	Then I should be able to register successfully
	
	Scenario: Data Driven With Parameter1
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign up
	#And I bought 2 pens
	And I enter my Username "LWP55"
	And I enter my Email "demo@example21.com"
	And I enter my password "PasswordSecure1"
	When I click on the sign up button
	Then I should be able to register successfully

	Scenario: Data Driven With Parameter2
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign up
	#And I bought 2 pens
	And I enter my Username "LWP66"
	And I enter my Email "demo@example13.com"
	And I enter my password "PasswordSecure444"
	When I click on the sign up button
	Then I should be able to register successfully
	
	
	
	
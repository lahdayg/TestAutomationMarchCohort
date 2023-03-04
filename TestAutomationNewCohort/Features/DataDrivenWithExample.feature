Feature: DataDrivenWithExample

A short summary of the feature


Scenario Outline: Data Driven With Example
	Given I navigate to the website "https://angularjs.realworld.io/#/"
	And I click on Sign up
	And I enter Username text "<Username>"
	And I enter Email text "<Email>"
	And I enter password text "<Password>"
	When I click on the sign up button
	Then I should be able to register successfully

	Examples: 
	| Username | Email            | Password       |
	| Richard  | demo@example.com | PasswordSecure |
	| Williams | william@demo.com | PasswordSecure |
	| Baba     | baba@demo.com    | PasswordSecure |
	

	
	
	

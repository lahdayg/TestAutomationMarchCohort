Feature: Registration

As a User
In Order to benefit from the website
I will need to first sign up or register

@tag1
Scenario Outline: Valid Registration
	Given I navigate to the website
	And I click on Sign up
	And I enter Username text "<Username>"
	And I enter Email text "<Email>"
	And I enter password text "<Password>"
	And I enter Username
	#And I enter Email
	#And I enter password
	#When I click on the sign up button
	#Then I should be able to register successfully

	Examples: 
	| Username | Email            | Password       |
	| Deji     | dj@demo.com      | PasswordSecure |
	| Williams | william@demo.com | PasswordSecure |
	| Richard  | rt@demo.com      | PasswordSecure |
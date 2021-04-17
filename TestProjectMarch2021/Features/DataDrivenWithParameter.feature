Feature: DataDrivenWithParameter
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Data Driven With Parameter
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on sign up button
	And I enter Username "learnwithpride33336"
	And I enter Email "demo268765@gmail.com"
	And I enter password "PasswordSecure"
	When I click on Sign up
	Then I should be able to sign up succefully





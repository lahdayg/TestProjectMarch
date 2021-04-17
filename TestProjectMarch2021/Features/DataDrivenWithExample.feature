Feature: DataDrivenWithExample
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Data Driven With Example
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on sign up button
	And the user enter Username "<Username>"
	And the user enter Email "<Email>"
	And the user enter password "<Password>"
	When I click on Sign up
	Then I should be able to sign up succefully

	Examples: 
	| Username       | Email                 | Password       |
	| TelleTobby4587 | telle478@dempo.com    | PasswordSecure |
	| Kelly1478      | kelly1258@rowland.com | PasswordSecure |
	| Richard5487    | richie4587@demo.com   | PasswordSecure |


	
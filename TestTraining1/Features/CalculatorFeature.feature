Feature: CalculatorFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Add two numbers
	Given I have entered <n1> and <n2> into the calculator
	When I press add
	Then the result should be <result> on the screen

	Examples: 
	| n1   | n2 | result |
	| 1    | 2  | 3      |
	| 10.5 | 10 | 20.5   |

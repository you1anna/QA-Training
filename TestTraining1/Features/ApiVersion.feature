Feature: ApiVersion
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: VersionApi
	Given I am calling the ContentApi
	When I request the version
	Then I get an OK response
	And I get a valid version response

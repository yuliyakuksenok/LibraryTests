Feature: Getting web API

@mytag
Scenario: Sending request for getting API
	Given I have an API web page
	When I send request to get API web 'https://boyns97jh5.execute-api.eu-west-1.amazonaws.com/Prod/swagger/v1/swagger.json'
	Then the result should have status code '200'
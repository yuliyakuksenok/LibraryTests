Feature: Correct work of Shelf

@newShelf
Scenario: I want to add new shelf to library
	Given API v1
	And Client is authorized in librarian role
	When I send the request for adding a shelf to "https://boyns97jh5.execute-api.eu-west-1.amazonaws.com/Prod/api/v1/Shelf"
	Then I get the successful response with code '200'
	And new shelf was added

Scenario: I want to get list of shelves
	Given API v1
	And Client is authorized in librarian role
	When I send request for getting list of shelves to "https://boyns97jh5.execute-api.eu-west-1.amazonaws.com/Prod/api/v1/Shelf"
	Then I get the successful response with code '200'
	And list of shelves is displayed

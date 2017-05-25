Feature: 6
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

	@login
Scenario: Paginator and Descending Sorting
	When I click paginator item and check sorting by 'id'
	  And I click paginator item and check sorting by 'Title'
	  And I click paginator item and check sorting by 'Parent id'
	  And I click paginator item and check sorting by 'Active'
	  Then I click 'Logout' button in header

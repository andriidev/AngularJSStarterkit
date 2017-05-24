Feature: 4 EditViewDeleteItems.feature
	You can view, edit, delete and query the items

@login
Scenario: View item
	Given I click 'Admin' button in the first item row
	When I click 'Show' button in the first item row
	Then I navigated to View item page
    And I see following elements

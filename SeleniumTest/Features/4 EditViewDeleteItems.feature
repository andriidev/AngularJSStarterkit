Feature: 4 EditViewDeleteItems.feature
	You can view, edit, delete and query the items

@login
Scenario: View item
	Given I click 'Admin' button in the first item row
	When I click 'Show' button in the first item row
	Then I landed to 'View' item page
     #And I see following elements
     #| ItemList |
     #|          |

@login
Scenario: Edit item
	Given I click 'Admin' button in the first item row
    When I click 'Edit' button in the first item row
    Then I landed to 'Edit' item page
    #When I change Parent_id and Title
    # And I click 'Submit' button
    #Then I see updated Parent_id and Title on item view page
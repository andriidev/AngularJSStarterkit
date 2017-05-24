Feature: 4 EditViewDeleteItems.feature
	You can view, edit, delete and query the items

@login
Scenario: View item From Home page
	Given I click 'Admin' button in the first item row
	When I click 'Show' button in the first item row
	Then I landed to 'View' item page
     #And I see following elements
     #| ItemList |
     #|          |

@login
Scenario: Edit item from Home page
	Given I click 'Admin' button in the first item row
    When I click 'Edit' button in the first item row
    Then I landed to 'Edit' item page
     And I change Parent_id and Title

@login
Scenario: Delete item from Home page
	Given I click 'Add new' button
	 And I create new 'ItemToDelete' item
	 And I search for the created 'ItemToDelete' item
	 And I click 'Admin' button in the first item row
    When I click 'Delete' button in the first item row
	 And i click  'OK' button in Notification pop-up
	Then I search for deleted item 'ItemToDelete' and can't find it
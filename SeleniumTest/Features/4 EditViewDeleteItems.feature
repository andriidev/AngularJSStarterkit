Feature: 4 EditViewDeleteItems.feature
	You can view, edit, delete and query the items

@login
Scenario: View item From Home page
	Given I click 'Admin' button in the first item row
	When I click 'Show' button in the first item row
	Then I landed to 'View' item page
     And I click 'Logout' button in header

Scenario: Edit item from View page
    Given I navigate to the 'Main' page
      And I click 'Login' button in header
	When I enter credentials and click Login button
    | Email                   | Password        |
    | validuser@malinator.com | ValidPassword2! |
      And I click in Item title in the table
	  And I click Edit button on Item View page
    Then I landed to 'Edit' item page
      And I change Parent_id and Title
      And I click 'Logout' button in header

Scenario: Edit item from Home page
    Given I navigate to the 'Main' page
      And I click 'Login' button in header
	When I enter credentials and click Login button
    | Email                   | Password        |
    | validuser@malinator.com | ValidPassword2! |
	Given I click 'Admin' button in the first item row
    When I click 'Edit' button in the first item row
    Then I landed to 'Edit' item page
      And I change Parent_id and Title
      And I click 'Logout' button in header

Scenario: Delete item from Home page
    Given I navigate to the 'Main' page
      And I click 'Login' button in header
	When I enter credentials and click Login button
    | Email                   | Password        |
    | validuser@malinator.com | ValidPassword2! |
	Given I click 'Add new' button
	  And I create new 'ItemToDelete' item
	  And I search for the created 'ItemToDelete' item
	  And I click 'Admin' button in the first item row
    When I click 'Delete' button in the first item row
	  And i click  'OK' button in Notification pop-up
	Then I search for deleted item 'ItemToDelete' and can't find it
      And I click 'Logout' button in header

@login
Scenario: Delete item using 'Remove' button on View page
	Given I click 'Add new' button
	  And I create new 'ItemToDelete' item
	  And I search for the created 'ItemToDelete' item
	When I click in Item title in the table
	  And I click Delete button on Item View page
	  And i click  'OK' button in Notification pop-up
	Then I search for deleted item 'ItemToDelete' and can't find it
      And I click 'Logout' button in header
Feature: 2 ItemCreation
	After you login you can create items (active or not) to add to the list

@login
Scenario Outline: Create active and not active item
    Given I click 'Add new' button
    When I create new Item filling Title field, Parent_Id field and Active staus
      | Title   | Parent_id   | Active   |
      | <Title> | <Parent_id> | <Active> |
    Then I click 'Logout' button in header

Examples: 
      | Title       | Parent_id | Active |
      | ActiveItem  | 1990      | true   |
      | ActiveItem  | 1991      | false  |
      | PassiveItem | 2030      | true   |
      | PassiveItem | 2029      | false  |





Feature: 3 ItemBelongToGroup
	Each item should belong to a group

@login
Scenario Outline: Created item goes to corresponding group depended by Parent_ID
    Given I click 'Add new' button
    When I create new Item from table and it can be found in corresponding group
      | Title   | Parent_id   | Active   | Group   |
      | <Title> | <Parent_id> | <Active> | <Group> |
    Then I click 'Logout' button in header

Examples: 
      | Title       | Parent_id | Active | Group  |
      | ActiveItem  | 1991      | false  | group1 |
      | ActiveItem  | 1992      | false  | group2 |
      | PassiveItem | 2003      | false  | group3 |
      | PassiveItem | 2004      | false  | group4 |
      | PassiveItem | 2005      | false  | group5 |
      | ActiveItem  | 2010      | false  | group1 |
      | PassiveItem | 2030      | false  | group3 |

	

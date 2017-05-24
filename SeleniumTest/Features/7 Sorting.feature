Feature: 7 Sorting.feature
	Sorting the table is enabled


@login
Scenario: Sorting items (id, title, parent id, active) in the table
    Given I click on 'Id' in the table header
    When I see that 'Id' sorted in descending order
    Then I click on 'Id' in the table header
      And I see that 'Id' sorted in ascending order
      And I click on 'Title' in the table header
      And I see that 'Title' sorted in descending order
      And I click on 'Title' in the table header
      And I see that 'Title' sorted in ascending order
      And I click on 'Parent id' in the table header
      And I see that 'Parent id' sorted in descending order
      And I click on 'Parent id' in the table header
      And I see that 'Parent id' sorted in ascending order
      And I click on 'Active' in the table header
      And I see that 'Active' sorted in descending order
      And I click on 'Active' in the table header
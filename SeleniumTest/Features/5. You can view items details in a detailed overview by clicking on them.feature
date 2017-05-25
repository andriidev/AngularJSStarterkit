Feature: 5. You can view items details in a detailed overview by clicking on them

@login
Scenario: View item From Home page
    When I click in Item title in the table
    Then I landed to 'View' item page
      And I click 'Logout' button in header


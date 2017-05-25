Feature: 1 Log in feature
	The application allows you to login with your email and password


Scenario: Login with valid credentials
    Given I navigate to the 'Main' page
    And I click 'Login' button in header
	When I enter credentials and click Login button
    | Email                   | Password        |
    | validuser@malinator.com | ValidPassword2! |
    Then I see 'successively logged in' message
      And I click 'Logout' button in header

Scenario Outline: Login with invalid credentials
    Given I navigate to the 'Main' page
    And I click 'Login' button in header
	When I enter credentials and click Login button
    | Email   | Password   |
    | <Email> | <Password> |
    Then I still see 'Login' button

Examples: 
    | Email                            | Password |
    | invalid email                    |          |
    | invalid@email                    | password |
    | emaildoesn'texist@mailinator.com | password |
    |                                  | password |
    |                                  |          |
    | validEmail@malinator.com         |          |




Feature: 9 LocalizationHandles
	 The application handles localization (English and French)

@login
Scenario: Add two numbers
	When I select 'french' from language drop-down 
    Then I see following item in 'french' 
    | ItemList        |
    | Home            |
    | Logout          |
    | Help            |
	| Global message  |
   
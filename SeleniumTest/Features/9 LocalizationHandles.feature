Feature: 9 LocalizationHandles
	 The application handles localization (English and French)


Scenario: French language
	When I select 'French' from language drop-down 
    Then I see elements in home page in 'French'

Scenario: English language
	When I select 'English' from language drop-down 
    Then I see elements in home page in 'English'
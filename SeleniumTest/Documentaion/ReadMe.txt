Test Approach:

Functional tests are automated implementing:
- Selenium WebDriver
- Page Object pattern
- BDD principles.
 
Page Object allows: 
- Incapsulate and separate code of Pages, Step actions and  Test Scenarious
- Easy support in case of UI/Functional changes
- Also can be implemented for API tests
- Reduce amount of code

Automation scenarious are written in Gherkin. This allows:
- Effective code reusage
- Manage test data in 'Scenario outline' for better test coverage
- Each test case can be executed independently in any consiquance

Selenium WebDriver:
- Most popular and powerfull opensource tool for functional test automation
- Emulates human iterations with browser
- Support most of internet browsers, programming languese and unit test frameworks from xUnit family
___________________________________________________



FrameWork Choise:


Usually best practice is to use the same programming language and toolset for test automation as used for development of application under test. This allows:
- Use the same infrastructure and tool-set as entire project
- Easies integrations with CI
- Developers' expertise is aplicable for complicated taks
As far as most of my test automation experience based on C# the following tool-set was utilised for this specific test task:
- MS Visual studio 2017
- Selenium WebDriver
- Specflow (Cucumber for .Net)
- xUnit
- MS Test
- target browser: Google Chome 
___________________________________________________



Tests covered:


Due to limited timeframe and based on assumption that task is for test automation - decision was to cover each Feature with at least one test case which will check core functionality.
Prepared test cases are collected in file AngularJSStarterkit\SeleniumTest\Documentaion\Manual Test Cases.xlsx
Each test cases is automated.
Current result is:
28 Scenarios Passed
4 scenarios Failed

Scenarios failed becaouse of bug - Login doesn't validate email format and accept login without passwird.


Potemtial improvements:
- Implement HTML reporting
- Add native brovser messages validation
- Add Check for screen elements presence on each Page
___________________________________________________



Explain clearly how to launch the automated tests:


To run automated tests you need:

Precondition:
- OS: Windows 7 or higher
- Browser: Chrome
- Visual studio 2017 (download and install from https://www.visualstudio.com/downloads/)
- Specflow plugin for Visual studio 2017:
1. In Visual studio go to Tools --> Extensions and Updates... --> Switch to Online
2. Search for 'Specflow for Visual studio'
3. Click 'Download' Specflow plugin. Restart Visual studio to install Specflow

Launch tests:
- Open the solution in Visual studio AngularJSStarterkit\SeleniumTest.sln
- Open Solution Explorer (View -> "Solution explorer" or Ctrl + Alt + L)
- Build or Rebuild project (Right click on SeleniumTest project in Solution Explorer --> Select Rebuild in menu
- In Test Explorer (if not appeared: Main menu, Test --> Windows --> Test Explorer) click on 'Group' button and Select 'Class' to sort tests by Features
- In Test Explorer click 'Run All' .
- Enjoy test execution and inspect test results

!!!
If for some reason you're not successful in running tests - please see gif animation of test run execution:
https://drive.google.com/file/d/0Bw-ivVvyG9boejFUTUt6V1RiWnc/view?usp=sharing



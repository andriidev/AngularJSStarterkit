using SeleniumTest.Utilities;
using SeleniumTest.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using NUnit;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SeleniumTest.Steps
{
    [Binding]
    class CommonSteps
    {

        private DriverPoC driver = new DriverPoC();
        private LoginPage loginPage = new LoginPage();
        private MainPage mainPage = new MainPage();

        [BeforeScenario("login")]
        public void BeforeScenarioLogIn()
        {
            GivenINavigateToThePage("login");
            loginPage.Login("user@mail.com", "password");
        }
        public CommonSteps()
        {
            PageFactory.InitElements(driver, loginPage);
            PageFactory.InitElements(driver, mainPage);
        }

        [Given(@"I navigate to the '(.*)' page")]
        public void GivenINavigateToThePage(string pageName)
        {
            switch (pageName.ToLower())
            {
                case "main":

                    driver.Navigate().GoToUrl(Properties.Settings.Default.WebAppUrl);
                    break;
                case "login":
                    driver.Navigate().GoToUrl(Properties.Settings.Default.WebAppUrl + "/#!/login");
                    break;
                case "items":
                    driver.Navigate().GoToUrl(Properties.Settings.Default.WebAppUrl + "/#!/items");
                    break;
                
                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }
    }
}

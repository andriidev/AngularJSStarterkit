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
using System;
using TechTalk.SpecFlow.Assist;

namespace SeleniumTest.Steps
{
    [Binding]
    class LogInPageSteps
    {
        private DriverPoC driver = new DriverPoC();
        private LoginPage loginPage = new LoginPage();
        private MainPage mainPage = new MainPage();

        public LogInPageSteps()
        {
            PageFactory.InitElements(driver, loginPage);
            PageFactory.InitElements(driver, mainPage);
        }

        [When(@"I enter credentials and click Login button")]
        public void WhenIEnterCredentialsAndClickLoginButton(Table credentials)
        {
            var item = credentials.CreateInstance<LogInTableToFill>();
            FillCredentials(item);
            loginPage.LoginButtonClick();
        }

        private void FillCredentials(LogInTableToFill item)
        {
            loginPage.EmailInputSendNewKeys(item.Email);
            loginPage.PasswordSendNewKeys(item.Password);
        }

        [Then(@"I see '(.*)' message")]
        public void ThenISeeMessage(string message)
        {
            switch (message.ToLower())
            {
                case "successively logged in":
                    Assert.AreEqual(Dictionary.EngDictionary["successively logged in"] , loginPage.SuccessLoginMessage.Text);
                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }

        [Then(@"I still see '(.*)' button")]
        public void ThenIStillSeeButton(string buttonName)
        {
            switch (buttonName.ToLower())
            {
                case "login":
                    Assert.True(mainPage.LogIntButtonHeader.Displayed);
                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }
    }
}

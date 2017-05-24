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

namespace SeleniumTest.Steps
{
    [Binding]
    class MainPageSteps
    {
        private DriverPoC driver = new DriverPoC();
        private MainPage mainPage = new MainPage();

        public MainPageSteps()
        {
            PageFactory.InitElements(driver, mainPage);
        }

        [Given(@"I click '(.*)' button in header")]
        [Then(@"I click '(.*)' button in header")]
        public void GivenIClickButtonInHeader(string button)
        {
            switch (button.ToLower())
            {
                case "login":
                    mainPage.LogInButtonHeaderClick();
                    break;
                case "logout":
                    mainPage.LogOutButtonHeaderClick();
                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }


    }
}

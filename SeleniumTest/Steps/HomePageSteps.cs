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
    class HomePageSteps
    {
        private DriverPoC driver = new DriverPoC();
        private HomePage homePage = new HomePage();

        public HomePageSteps()
        {
            PageFactory.InitElements(driver, homePage);
        }

        [Given(@"I click '(.*)' button")]
        public void GivenIClickButton(string buttonName)
        {
            switch (buttonName.ToLower())
            {
                case "add new":
                    homePage.AddNewButtonClick();
                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }

        [Given(@"I click '(.*)' button in the first item row")]
        [When(@"I click '(.*)' button in the first item row")]
        public void GivenIClickButtonInTheFirstItemRow(string buttonName)
        {
            switch (buttonName.ToLower())
            {
                case "admin":
                    homePage.AdminButtonClick();
                    break;
                case "show":
                    homePage.ShowButtonClick();
                    break;
                case "edit":
                    homePage.EditButtonClick();
                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }



    }
}

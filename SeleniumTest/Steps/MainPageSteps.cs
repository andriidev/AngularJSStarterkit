using SeleniumTest.Utilities;
using SeleniumTest.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using Xunit;
using OpenQA.Selenium.Chrome;
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

        [When(@"I click paginator item")]
        public void WhenIClickPaginatorItem()
        {

            bool found = false;
            int paginatorPageNumber = 0;

            int paginationCount = mainPage.GetPaginationCount();
            mainPage.SetDriver(driver);

            while (paginatorPageNumber <= paginationCount && !found)
            {
                public void ThenISeeThatSortedInDescendingOrder("id");

                paginatorPageNumber++;
                if (paginatorPageNumber < paginationCount)
                {
                    mainPage.ClickPaginationNumber(paginatorPageNumber);
                }


            }
            Assert.False(found);
        }



    }
}

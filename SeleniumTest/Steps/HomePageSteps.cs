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
using System.Collections.Generic;
using System.Linq;

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
        [Given(@"I click on '(.*)' in the table header")]
        [Then(@"I click on '(.*)' in the table header")]
        public void AndIClickOnInTheTableHeader(string item)
        {
            switch (item.ToLower())
            {
                case "id":
                    homePage.IdTableHeader.Click();
                    break;

                case "title":
                    homePage.TitleTableHeader.Click();
                    break;

                case "parent id":
                    homePage.ParentIdTableHeader.Click();
                    break;

                case "active":
                    homePage.ActiveTableHeader.Click();
                    break;
                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }

        [When(@"I see that '(.*)' sorted in descending order")]
        [Then(@"I see that '(.*)' sorted in descending order")]
        public void ThenISeeThatSortedInDescendingOrder(string item)
        {
            var expectedList = new List<string>();
            var actualList = new List<string>();

            switch (item.ToLower())
            {
                case "id":
                    actualList = Helper.ConvertWebElementList(homePage.IdList);
                    break;

                case "title":
                    actualList = Helper.ConvertWebElementList(homePage.TitleList);
                    break;

                case "parent id":
                    actualList = Helper.ConvertWebElementList(homePage.ParentIdList);
                    break;

                case "active":
                    actualList = Helper.ConvertWebElementList(homePage.ActiveList);
                    break;
            }
            expectedList = new List<string>(actualList);

            expectedList.OrderByDescending(el => el);

            Assert.AreEqual(expectedList, actualList);
        }

        [Then(@"I see that '(.*)' sorted in ascending order")]
        public void ThenISeeThatSortedInAscendingOrder(string item)
        {
            var expectedList = new List<string>();
            var actualList = new List<string>();
            switch (item.ToLower())
            {
                case "id":
                    actualList = Helper.ConvertWebElementList(homePage.IdList);
                    break;

                case "title":
                    actualList = Helper.ConvertWebElementList(homePage.TitleList);
                    break;

                case "parent id":
                    actualList = Helper.ConvertWebElementList(homePage.ParentIdList);
                    break;

                case "active":
                    actualList = Helper.ConvertWebElementList(homePage.ActiveList);
                    break;
            }
            expectedList = new List<string>(actualList);
            expectedList.Sort();

            Assert.AreEqual(expectedList, actualList);
        }

        [Given(@"I select '(.*)' from language drop-down")]
        public void GivenISelectFromLanguageDrop_Down(string value)
        {
            switch(value)
            {
            
            }
        }

        [When(@"I see following item in '(.*)'")]
        public void WhenISeeFollowingItemIn(string p0, Table table)
        {
            
        }

    }

    }





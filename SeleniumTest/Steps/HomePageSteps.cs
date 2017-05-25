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

        public object Translations { get; private set; }

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

        [When(@"I select '(.*)' from language drop-down")]
        public void GivenISelectFromLanguageDrop_Down(string value)
        {
            homePage.SelectLocalisation(value);
        }

        [Then(@"I see elements in home page in '(.*)'")]
        public void ThenISeeElementsInHomePageIn(string value)
        {
            switch (value.ToLower())
            {
                case "french":
                    Assert.AreEqual(Dictionary.FrDictionary["Home"], homePage.HomeButton.Text);
                    Assert.AreEqual(Dictionary.FrDictionary["Logout"], homePage.LogoutButton.Text);
                    Assert.AreEqual(Dictionary.FrDictionary["Help"], homePage.HelpButton.Text);
                    Assert.AreEqual(Dictionary.FrDictionary["Global message"], homePage.GlobalMessage.Text);

                    break;

                case "english":
                    Assert.AreEqual(Dictionary.EngDictionary["Home"], homePage.HomeButton.Text);
                    Assert.AreEqual(Dictionary.EngDictionary["Logout"], homePage.LogoutButton.Text);
                    Assert.AreEqual(Dictionary.EngDictionary["Help"], homePage.HelpButton.Text);
                    Assert.AreEqual(Dictionary.EngDictionary["Global message"], homePage.GlobalMessage.Text);

                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }
    }
}


        
    



    




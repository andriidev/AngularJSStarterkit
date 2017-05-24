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
    class ItemPageSteps
    {
        private DriverPoC driver = new DriverPoC();
        private ItemPage itemPage = new ItemPage();
        private HomePage homePage = new HomePage();

        public ItemPageSteps()
        {
            PageFactory.InitElements(driver, itemPage);
            PageFactory.InitElements(driver, homePage);
        }

        [When(@"I create new Item filling Title field, Parent_Id field and Active staus")]
        public void WhenICreateNewItemFillingTitleFieldParent_IdFieldAndActiveStaus(Table table)
        {
            var itemTable = table.CreateInstance<ItemTableToFill>();
            itemTable.Title += DateTime.Now.ToString(" yyyy.MM.dd hh.mm.ss");
            itemPage.CreateNewItem(itemTable.Title, itemTable.Parent_id, Convert.ToBoolean(itemTable.Active));
            homePage.SearchInputSendNewKeys(itemTable.Title);
            Assert.AreEqual(itemTable.Title, homePage.FirstRowTitle.Text);
        }

        [When(@"I create new Item from table and it can be found in corresponding group")]
        public void WhenICreateNewItemFromTableAndItCanBeFoundInCorrespondingGroup(Table table)
        {
            var itemTable = table.CreateInstance<ItemTableToFill>();
            itemTable.Title += DateTime.Now.ToString(" yyyy.MM.dd hh.mm.ss");
            itemPage.CreateNewItem(itemTable.Title, itemTable.Parent_id, Convert.ToBoolean(itemTable.Active));
            homePage.SearchInputSendNewKeys(itemTable.Title);
            new SelectElement(homePage.GroupDropDown).SelectByText(itemTable.Group);
            Assert.AreEqual(itemTable.Title, homePage.FirstRowTitle.Text);
        }

        [Then(@"I landed to '(.*)' item page")]
        public void ThenILandedToItemPage(string PageName)
        {
            switch (PageName.ToLower())
            {
                case "view":
                    Assert.AreEqual(Dictionary.EngDictionary["View"], itemPage.ItemViewPageTitle.Text);
                    break;
                case "edit":
                    Assert.AreEqual(Dictionary.EngDictionary["Edit"], itemPage.ItemViewPageTitle.Text);
                    break;
                case "create":
                    Assert.AreEqual(Dictionary.EngDictionary["create"], itemPage.ItemViewPageTitle.Text);
                    break;

            }
        }




    }
}

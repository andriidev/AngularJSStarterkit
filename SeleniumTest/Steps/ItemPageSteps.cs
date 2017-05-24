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
            Assert.Equal(itemTable.Title, homePage.FirstRowTitle.Text);
        }

        [When(@"I create new Item from table and it can be found in corresponding group")]
        public void WhenICreateNewItemFromTableAndItCanBeFoundInCorrespondingGroup(Table table)
        {
            var itemTable = table.CreateInstance<ItemTableToFill>();
            itemTable.Title += DateTime.Now.ToString(" yyyy.MM.dd hh.mm.ss");
            itemPage.CreateNewItem(itemTable.Title, itemTable.Parent_id, Convert.ToBoolean(itemTable.Active));
            homePage.SearchInputSendNewKeys(itemTable.Title);
            new SelectElement(homePage.GroupDropDown).SelectByText(itemTable.Group);
            Assert.Equal(itemTable.Title, homePage.FirstRowTitle.Text);
        }

        [Then(@"I landed to '(.*)' item page")]
        public void ThenILandedToItemPage(string PageName)
        {
            switch (PageName.ToLower())
            {
                case "view":
                    Assert.Equal(Dictionary.EngDictionary["View"], itemPage.ItemViewPageTitle.Text);
                    break;
                case "edit":
                    Assert.Equal(Dictionary.EngDictionary["Edit"], itemPage.ItemViewPageTitle.Text);
                    break;
                case "create":
                    Assert.Equal(Dictionary.EngDictionary["create"], itemPage.ItemViewPageTitle.Text);
                    break;

            }
        }

        [Then(@"I change Parent_id and Title")]
        public void ThenIChangeParent_IdAndTitle()
        {
            string title = itemPage.Title.GetAttribute("value");
            title += "!";
            int parent_id = Convert.ToInt16(itemPage.ParentId.GetAttribute("value"));
            parent_id += 1;
            itemPage.CreateNewItem(title, parent_id.ToString(), true);

            Assert.Contains(title, itemPage.ItemTitleView.Text.Split( ));
            Assert.Contains(parent_id.ToString(), itemPage.ItemParentIdView.Text.Split());
        }

        [Given(@"I create new '(.*)' item")]
        public void GivenICreateNewItem(string itemName)
        {
            itemPage.CreateNewItem(itemName, "1990", true);
        }

        [Given(@"I search for the created '(.*)' item")]
        public void GivenISearchForTheCreatedItem(string itemName)
        {
            homePage.SearchInputSendNewKeys(itemName);
        }

        [When(@"i click  '(.*)' button in Notification pop-up")]
        public void WhenIClickButtonInNotificationPop_Up(string p0)
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        [Then(@"I search for deleted item '(.*)' and can't find it")]
        public void ThenISearchForDeletedItemAndCanTFindIt(string itemName)
        {
            homePage.SearchInputSendNewKeys(itemName);
            Assert.Throws<NoSuchElementException>(()=> homePage.FirstRowTitle.Displayed);
        }


    }
}

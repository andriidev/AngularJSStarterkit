using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTest.PageObjects
{
    class HomePage
    {
        //Input fields
        [FindsBy(How = How.CssSelector, Using = "[ng-model='searchInput']")]
        public IWebElement SearchInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "[ng-change='resetNestedGroup()']")]
        public IWebElement GroupDropDown { get; set; }

        //Text, Labels
        [FindsBy(How = How.CssSelector, Using = "td:nth-child(2) > a")]
        public IWebElement FirstRowTitle { get; set; }

        //Buttons
        [FindsBy(How = How.CssSelector, Using = "[ng-click='newItem()']")]
        public IWebElement AddNewButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "tr:nth-child(1) > td:nth-child(5) > div > button")]
        public IWebElement AdminButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "[ng-click='showItem(item.id)']")]
        public IWebElement ShowButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "[ng-click='editItem(item.id)']")]
        public IWebElement EditButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "[ng-really-click='deleteItem(item.id)']")]
        public IWebElement DeleteButton { get; set; }

        //Actions
        public void AddNewButtonClick()
        {
            AddNewButton.Click();
        }
        public void AdminButtonClick()
        {
            AdminButton.Click();
        }
        public void ShowButtonClick()
        {
            ShowButton.Click();
        }
        public void EditButtonClick()
        {
            EditButton.Click();
        }
        public void DeleteButtonClick()
        {
            DeleteButton.Click();
        }
        public void SearchInputSendNewKeys(string value)
        {
            SearchInput.Clear();
            SearchInput.SendKeys(value);
        }
    }
}

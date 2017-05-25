using System.Collections.Generic;
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
        [FindsBy(How = How.CssSelector, Using = "th:nth-child(1) > a")]
        public IWebElement IdTableHeader { get; set; }
        [FindsBy(How = How.CssSelector, Using = "th:nth-child(2) > a")]
        public IWebElement TitleTableHeader { get; set; }
        [FindsBy(How = How.CssSelector, Using = "th:nth-child(3) > a")]
        public IWebElement ParentIdTableHeader { get; set; }
        [FindsBy(How = How.CssSelector, Using = "th:nth-child(4) > a")]
        public IWebElement ActiveTableHeader { get; set; }
        [FindsBy(How = How.CssSelector, Using = "td:nth-child(1)")]
        public IList<IWebElement> IdList { get; set; }
        [FindsBy(How = How.CssSelector, Using = "td:nth-child(2)")]
        public IList<IWebElement> TitleList { get; set; }
        [FindsBy(How = How.CssSelector, Using = "td:nth-child(3)")]
        public IList<IWebElement> ParentIdList { get; set; }
        [FindsBy(How = How.CssSelector, Using = "td:nth-child(4)")]
        public IList<IWebElement> ActiveList { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".navbar-collapse > ul > li.active > a > span")]
        public IWebElement HomeButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".navbar-collapse > ul > li:nth-child(3) > a")]
        public IWebElement LogoutButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".navbar-collapse > ul > li:nth-child(4) > a")]
        public IWebElement HelpButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "ng-view > div > div.well > p")]
        public IWebElement GlobalMessage { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".dropdown-toggle.ng-binding")]
        public IWebElement LanguageDropdown { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".btn.ng-scope")]
        public IList<IWebElement> OptionsInLanguageDropdown { get; set; }


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
        public void SelectLocalisation(string language)
        {
            LanguageDropdown.Click();
            switch (language.ToLower())
            {
                case "english":
                    OptionsInLanguageDropdown[0].Click();
                    break;
                case "french":
                    OptionsInLanguageDropdown[1].Click();
                    break;
            }
        }
    }
}

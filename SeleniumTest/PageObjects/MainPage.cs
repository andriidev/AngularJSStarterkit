using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace SeleniumTest.PageObjects
{
    class MainPage
    {
        //Buttons
        [FindsBy(How = How.CssSelector, Using = "[href='#!logout']")]
        public IWebElement LogOutButtonHeader { get; set; }
        [FindsBy(How = How.CssSelector, Using = "[href='#!login']")]
        public IWebElement LogIntButtonHeader { get; set; }
        [FindsBy(How = How.CssSelector, Using = "[ng-click='setCurrent(pageNumber)']")]
        public IList<IWebElement> Paginator { get; set; }
        
        

        //Actions

        public void LogOutButtonHeaderClick()
        {
            LogOutButtonHeader.Click();
        }
        public void LogInButtonHeaderClick()
        {
            LogIntButtonHeader.Click();
        }
        public int GetPaginationCount()
        {
            var visiblePaginatonCount = Paginator.Count;
            string lastPaginationNumber = Paginator[visiblePaginatonCount - 1].Text;
            return int.Parse(lastPaginationNumber);
        }

        public void ClickPaginationNumber(int paginatorPageNumber)
        {
            Paginator[paginatorPageNumber].Click();
        }

    }

}

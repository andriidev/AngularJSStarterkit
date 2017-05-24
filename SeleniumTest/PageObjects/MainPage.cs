using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTest.PageObjects
{
    class MainPage
    {
        //Buttons
        [FindsBy(How = How.CssSelector, Using = "[href='#!logout']")]
        public IWebElement LogOutButtonHeader { get; set; }
        [FindsBy(How = How.CssSelector, Using = "[href='#!login']")]
        public IWebElement LogIntButtonHeader { get; set; }

        //Actions

        public void LogOutButtonHeaderClick()
        {
            LogOutButtonHeader.Click();
        }
        public void LogInButtonHeaderClick()
        {
            LogIntButtonHeader.Click();
        }
    }
    
}

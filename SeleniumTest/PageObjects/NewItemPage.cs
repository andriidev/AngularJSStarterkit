using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTest.PageObjects
{
    class NewItemPage
    {
        //Inputs
        [FindsBy(How = How.CssSelector, Using = "[ng-model='new.title_en']")]
        public IWebElement Title { get; set; }
        [FindsBy(How = How.CssSelector, Using = "[ng-model='new.parent_id']")]
        public IWebElement ParentId { get; set; }
        [FindsBy(How = How.CssSelector, Using = "[ng-model='new.active']")]
        public IWebElement ActiveChecBox { get; set; }

        //Buttons
        [FindsBy(How = How.CssSelector, Using = ".btn.btn-primary.pull-right")]
        public IWebElement SubmitButton { get; set; }


        public void TitleSendNewKeys(string title)
        {
            Title.Clear();
            Title.SendKeys(title);
        }
        public void ParentIdSendNewKeys(string parentID)
        {
            ParentId.Clear();
            ParentId.SendKeys(parentID);
        }
        public void CreateNewItem(string title, string parentId, bool active)
        {
            TitleSendNewKeys(title);
            ParentIdSendNewKeys(parentId);

            if (active == true)
            {
                ActiveChecBox.Click();
            }

            SubmitButton.Click();
        }
    }
}

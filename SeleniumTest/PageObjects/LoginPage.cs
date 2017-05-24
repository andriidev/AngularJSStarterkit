using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTest.PageObjects
{
    class LoginPage
    {
        //Input fields
        [FindsBy(How = How.CssSelector, Using = "[ng-model='user.email']")]
        public IWebElement EmailInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "[ng-model='user.password']")]
        public IWebElement PasswordInput { get; set; }

        //Labels, text
        [FindsBy(How = How.CssSelector, Using = ".ng-binding.ng-scope")]
        public IWebElement SuccessLoginMessage { get; set; }
        [FindsBy(How = How.Id, Using = "")]
        public IWebElement LoginErrorMessage { get; set; }

        //Buttons
        [FindsBy(How = How.CssSelector, Using = ".btn.btn-default")]
        public IWebElement LoginButton { get; set; }

        //Actions
        public void EmailInputSendNewKeys(string userName)
        {
            EmailInput.Clear();
            EmailInput.SendKeys(userName);
        }
        public void PasswordSendNewKeys(string password)
        {
            PasswordInput.Clear();
            PasswordInput.SendKeys(password);
        }
        public void LoginButtonClick()
        {
            LoginButton.Click();
        }
        public void Login(string email, string password)
        {
            EmailInputSendNewKeys(email);
            PasswordSendNewKeys(password);
            LoginButtonClick();
        }

    }
}

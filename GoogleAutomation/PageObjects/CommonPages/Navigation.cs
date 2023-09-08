using CynkyWrapper;
using CynkyWrapper.Configuration;
using OpenQA.Selenium;

namespace GoogleAutomation.PageObjects.CommonPages
{
    public class Navigation
    {
        IWebDriver _Driver;

        public Navigation(IWebDriver driver)
        {
            _Driver = driver;
        }

        #region Locators

        PageElement Button(string text, int index = 1) => new PageElement(_Driver, By.XPath($"(//button[contains(.,'{text}')])[{index}]"));

        #endregion

        #region Actions

        public void NavigateToHomePage()
        {
            _Driver.Navigate().GoToUrl(CynkyConfigManager.SiteUrl);
            if (Button("Reject all").ElementExists())
                ClickButton("Reject all");
        }

        public void ClickButton(string text, int index = 1)
        {
            Button(text, index).Click();
        }



        #endregion
    }
}
using CynkyDriver;
using CynkyDriver.Configuration;
using OpenQA.Selenium;

namespace GoogleYouTube.PageObjects.CommonPages
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
        PageElement YouTube_button(string text) => new PageElement(_Driver, By.XPath($"//button[contains(.,'{text}') and contains(@class,'button-shape')]"));

        #endregion

        #region Actions

        public void NavigateToGoogleSearchHomePage()
        {
            _Driver.Navigate().GoToUrl(CynkyConfigManager.BaseSiteUrl);
            if (Button("Reject all").ElementExists())
                Button("Reject all").Click();
        }

        public void NavigateToYouTubeHomePage()
        {
            _Driver.Navigate().GoToUrl("https://www.youtube.com/");
            if (YouTube_button("Reject all").ElementExists())
                YouTube_button("Reject all").Click();
        }

        #endregion
    }
}
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

        PageElement Button(string text, int index = 1) => new PageElement(_Driver, By.XPath($"(//*[translate(normalize-space(.),'ABCDEFGHIJKLMNOPQRSTUVWXYZ','abcdefghijklmnopqrstuvwxyz')= \"{text.ToLower()}\" and not(self::span and count(../span) >1)]//ancestor::*[(self::button or self::a or @onclick or @role='button') and not(contains(@class,'banner'))])[{index}]"));

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
            if (Button("Reject all").ElementExists())
                Button("Reject all").Click();
        }

        #endregion
    }
}
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

        PageElement Button(string text, int index = 1) => new PageElement(_Driver, By.XPath($"(//*[(self::button or self::a or self::input or @onclick or @role='button')  and (contains(translate(normalize-space(.),'ABCDEFGHIJKLMNOPQRSTUVWXYZ','abcdefghijklmnopqrstuvwxyz'),\"{text.ToLower()}\") or contains(@class,\"{text}\") or contains(@title,\"{text}\") or contains(@value,\"{text}\")) and not(contains(@class,'disable') or @disabled)])[{index}]"));

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
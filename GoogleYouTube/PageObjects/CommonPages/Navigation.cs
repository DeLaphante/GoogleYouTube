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

        PageElement Button(string text, int index = 1) => new PageElement(_Driver, By.XPath($"(//button[translate(normalize-space(.),'ABCDEFGHIJKLMNOPQRSTUVWXYZ','abcdefghijklmnopqrstuvwxyz')=\"{text.ToLower()}\"]|//input[@value=\"{text}\"]|//a[not(ancestor::div[contains(@class,'banner')]) and translate(normalize-space(.),'ABCDEFGHIJKLMNOPQRSTUVWXYZ','abcdefghijklmnopqrstuvwxyz')=\"{text.ToLower()}\" or contains(@class,\"{text}\")]|//a[not(ancestor::div[contains(@class,'banner')]) and span[translate(normalize-space(.),'ABCDEFGHIJKLMNOPQRSTUVWXYZ','abcdefghijklmnopqrstuvwxyz')=\"{text.ToLower()}\"]]|//button[span[translate(normalize-space(.),'ABCDEFGHIJKLMNOPQRSTUVWXYZ','abcdefghijklmnopqrstuvwxyz')=\"{text.ToLower()}\"]]|//p[translate(normalize-space(.),'ABCDEFGHIJKLMNOPQRSTUVWXYZ','abcdefghijklmnopqrstuvwxyz')=\"{text.ToLower()}\"])[{index}]"));

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
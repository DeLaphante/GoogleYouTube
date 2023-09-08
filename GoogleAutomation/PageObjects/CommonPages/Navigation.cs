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
        PageElement Youtube_button(string text) => new PageElement(_Driver, By.XPath($"//button[contains(.,'{text}') and contains(@class,'button-shape')]"));

        #endregion

        #region Actions

        public void NavigateToGoogleSearchHomePage()
        {
            _Driver.Navigate().GoToUrl(CynkyConfigManager.SiteUrl);
            if (Button("Reject all").ElementExists())
                Button("Reject all").Click();
        }

        public void NavigateToYoutubeHomePage()
        {
            _Driver.Navigate().GoToUrl("https://www.youtube.com/");
            if (Youtube_button("Reject all").ElementExists())
                Youtube_button("Reject all").Click();
        }

        #endregion
    }
}
using CynkyDriver;
using OpenQA.Selenium;
using System;

namespace GoogleYouTube.PageObjects.CommonPages
{
    public class YouTubeHomePage
    {
        IWebDriver _Driver;

        public YouTubeHomePage(IWebDriver driver)
        {
            _Driver = driver;
        }

        #region Locators

        PageElement Search_textbox => new PageElement(_Driver, By.XPath($"//input[@id='search']"));
        PageElement Results_label => new PageElement(_Driver, By.XPath($"//ytd-video-renderer|//ytd-playlist-renderer"));

        #endregion

        #region Actions

        public void Search(string term)
        {
            Search_textbox.Click();
            Search_textbox.SendKeysNoValidation(term + Keys.Enter);
        }

        public int GetNumberOfSearchResults()
        {
            if (!Results_label.IsDisplayed())
                throw new Exception("Results not displayed!");
            return Results_label.GetAllElements().Count;
        }
        #endregion
    }
}
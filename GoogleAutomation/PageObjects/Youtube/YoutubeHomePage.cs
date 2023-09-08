using CynkyWrapper;
using OpenQA.Selenium;
using System;

namespace GoogleAutomation.PageObjects.CommonPages
{
    public class YoutubeHomePage : Navigation
    {
        IWebDriver _Driver;

        public YoutubeHomePage(IWebDriver driver) : base(driver)
        {
            _Driver = driver;
        }

        #region Locators

        PageElement Search_textbox => new PageElement(_Driver, By.XPath($"//input[@id='search']"));
        PageElement Results_label => new PageElement(_Driver, By.XPath($"//*[@bigger-thumbs-style='DEFAULT' and contains(@class,'renderer')]"));

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
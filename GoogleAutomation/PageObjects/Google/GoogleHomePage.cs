using CynkyWrapper;
using OpenQA.Selenium;
using System;

namespace GoogleAutomation.PageObjects.CommonPages
{
    public class GoogleHomePage : Navigation
    {
        IWebDriver _Driver;

        public GoogleHomePage(IWebDriver driver) : base(driver)
        {
            _Driver = driver;
        }

        #region Locators

        PageElement Search_textbox => new PageElement(_Driver, By.XPath($"//textarea[@title='Search']"));
        PageElement Results_label => new PageElement(_Driver, By.XPath($"//div[@id='search']//div[@jscontroller and @lang]"));

        #endregion

        #region Actions

        public void Search(string term)
        {
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
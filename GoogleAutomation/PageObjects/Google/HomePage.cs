using CynkyWrapper;
using OpenQA.Selenium;

namespace GoogleAutomation.PageObjects.CommonPages
{
    public class HomePage : Navigation
    {
        IWebDriver _Driver;

        public HomePage(IWebDriver driver) : base(driver)
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
            return Results_label.GetAllElements().Count;
        }
        #endregion
    }
}
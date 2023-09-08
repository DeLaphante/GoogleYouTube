using FluentAssertions;
using GoogleAutomation.PageObjects.CommonPages;
using TechTalk.SpecFlow;

namespace DemoAutomation.StepDefinitions.UI
{
    [Binding]
    public class Google_UISteps
    {

        GoogleHomePage _GoogleHomePage;

        public Google_UISteps(ScenarioContext scenarioContext)
        {
            _GoogleHomePage = scenarioContext.ScenarioContainer.Resolve<GoogleHomePage>();
        }

        [When(@"user searches for '([^']*)' on google search")]
        public void WhenUserSearchFor(string text)
        {
            _GoogleHomePage.Search(text);
        }

        [Then(@"a google search results with atleast '([^']*)' items is displayed")]
        public void ThenASearchResultsWithAtleastItemsIsDisplayed(int numberOfItems)
        {
            _GoogleHomePage.GetNumberOfSearchResults().Should().BeGreaterThan(numberOfItems);
        }


    }
}

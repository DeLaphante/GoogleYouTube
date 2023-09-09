using FluentAssertions;
using GoogleYoutube.PageObjects.CommonPages;
using TechTalk.SpecFlow;

namespace GoogleYoutube.StepDefinitions.UI
{
    [Binding]
    public class Google_UISteps
    {

        GoogleHomePage _GoogleHomePage;

        public Google_UISteps(ScenarioContext scenarioContext)
        {
            _GoogleHomePage = scenarioContext.ScenarioContainer.Resolve<GoogleHomePage>();
        }

        [StepDefinition(@"user searches for '([^']*)' on google search")]
        public void WhenUserSearchFor(string text)
        {
            _GoogleHomePage.Search(text);
        }

        [StepDefinition(@"a google search results with atleast '([^']*)' items is displayed")]
        public void ThenASearchResultsWithAtleastItemsIsDisplayed(int numberOfItems)
        {
            _GoogleHomePage.GetNumberOfSearchResults().Should().BeGreaterThan(numberOfItems);
        }


    }
}

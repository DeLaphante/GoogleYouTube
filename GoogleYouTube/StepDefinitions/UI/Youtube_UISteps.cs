using FluentAssertions;
using GoogleYouTube.PageObjects.CommonPages;
using Reqnroll;

namespace GoogleYouTube.StepDefinitions.UI
{
    [Binding]
    public class YouTube_UISteps
    {

        YouTubeHomePage _YouTubeHomePage;

        public YouTube_UISteps(ScenarioContext scenarioContext)
        {
            _YouTubeHomePage = scenarioContext.ScenarioContainer.Resolve<YouTubeHomePage>();
        }

        [StepDefinition(@"user searches for '([^']*)' on YouTube search")]
        public void WhenUserSearchFor(string text)
        {
            _YouTubeHomePage.Search(text);
        }

        [StepDefinition(@"a YouTube search results with atleast '([^']*)' items is displayed")]
        public void ThenASearchResultsWithAtleastItemsIsDisplayed(int numberOfItems)
        {
            _YouTubeHomePage.GetNumberOfSearchResults().Should().BeGreaterThan(numberOfItems);
        }


    }
}

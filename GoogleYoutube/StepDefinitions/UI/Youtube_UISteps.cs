using FluentAssertions;
using GoogleYoutube.PageObjects.CommonPages;
using TechTalk.SpecFlow;

namespace GoogleYoutube.StepDefinitions.UI
{
    [Binding]
    public class Youtube_UISteps
    {

        YoutubeHomePage _YoutubeHomePage;

        public Youtube_UISteps(ScenarioContext scenarioContext)
        {
            _YoutubeHomePage = scenarioContext.ScenarioContainer.Resolve<YoutubeHomePage>();
        }

        [StepDefinition(@"user searches for '([^']*)' on youtube search")]
        public void WhenUserSearchFor(string text)
        {
            _YoutubeHomePage.Search(text);
        }

        [StepDefinition(@"a youtube search results with atleast '([^']*)' items is displayed")]
        public void ThenASearchResultsWithAtleastItemsIsDisplayed(int numberOfItems)
        {
            _YoutubeHomePage.GetNumberOfSearchResults().Should().BeGreaterThan(numberOfItems);
        }


    }
}

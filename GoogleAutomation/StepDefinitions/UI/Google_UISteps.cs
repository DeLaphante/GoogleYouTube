using FluentAssertions;
using GoogleAutomation.PageObjects.CommonPages;
using TechTalk.SpecFlow;

namespace DemoAutomation.StepDefinitions.UI
{
    [Binding]
    public class Google_UISteps
    {

        HomePage _HomePage;

        public Google_UISteps(ScenarioContext scenarioContext)
        {
            _HomePage = scenarioContext.ScenarioContainer.Resolve<HomePage>();
        }

        [When(@"user search for '([^']*)'")]
        public void WhenUserSearchFor(string text)
        {
            _HomePage.Search(text);
        }

        [Then(@"a search results with atleast '([^']*)' items is displayed")]
        public void ThenASearchResultsWithAtleastItemsIsDisplayed(int numberOfItems)
        {
            _HomePage.GetNumberOfSearchResults().Should().BeGreaterThan(numberOfItems);
        }


    }
}

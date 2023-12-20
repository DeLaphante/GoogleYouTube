using GoogleYouTube.PageObjects.CommonPages;
using TechTalk.SpecFlow;

namespace GoogleYouTube.StepDefinitions.UI.Common
{
    [Binding]
    public sealed class Common_UISteps
    {
        Navigation _Navigation;

        public Common_UISteps(ScenarioContext scenarioContext)
        {
            _Navigation = scenarioContext.ScenarioContainer.Resolve<Navigation>();
        }

        [StepDefinition(@"user is on the Google search homepage")]
        public void GivenUserNavigatesToTheHomePage()
        {
            _Navigation.NavigateToGoogleSearchHomePage();
        }

        [StepDefinition(@"user is on the YouTube homepage")]
        public void GivenUserNavigatesToTheYouTubeHomePage()
        {
            _Navigation.NavigateToYouTubeHomePage();
        }

    }
}

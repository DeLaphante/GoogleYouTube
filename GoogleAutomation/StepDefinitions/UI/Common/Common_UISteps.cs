using GoogleAutomation.PageObjects.CommonPages;
using TechTalk.SpecFlow;

namespace GoogleAutomation.StepDefinitions.UI.Common
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

        [StepDefinition(@"user is on the Youtube homepage")]
        public void GivenUserNavigatesToTheYoutubeHomePage()
        {
            _Navigation.NavigateToYoutubeHomePage();
        }

    }
}

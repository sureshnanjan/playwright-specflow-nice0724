using HerokuApp.Operations;
using HerokuApp.Implementation;
namespace HerokuApp.Implementation.Features.StepDefinitions
{
    [Binding]
    public sealed class HerokuAppStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly ScenarioContext _scenarioContext;
        private string actualHeading = String.Empty;
        private string actualSubHeading = String.Empty;
        private IHerokuAppOperations page; // = default(IHomePageOperations);
        //private IHerokuAppOperations navigatedPage; // = default(IHerokuAppOperations); 

        public HerokuAppStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            this.page = default;
            //this.navigatedPage = default;
        }
        [Given(@"The Application is available")]
        public void GivenTheApplicationIsAvailable()
        {
            Console.WriteLine("Heroku App Is Launched");
            page = new HomePage(null);
        }

        [When(@"the heading is accessed")]
        public void WhenTheHeadingIsAccessed()
        {
            // Use Page Object helpers to populate the actual heading
            this.actualHeading = page.GetHeading().Result;
            // 

        }

        [Then(@"is should be ""(.*)""")]
        public void ThenIsShouldBe(string p0)
        {
            this.actualHeading.Should().Match(p0);
        }

        [When(@"the example ""(.*)"" is accessed")]
        [Given(@"the example ""(.*)"" is accessed")]
        public void WhenTheExampleIsAccessed(string exampleName)
        {
            page = ((IHomePageOperations)page).goToExample(exampleName) ;
            //page = (IHerokuAppOperations)navigatedPage;
        }

        [When(@"available examples are checked")]
        public void WhenAvailableExamplesAreChecked()
        {
            int count  = ((IHomePageOperations)page).getExampleCount().Result;
            _scenarioContext.Add("example_count", count);
        }

        [Then(@"it should have (.*) examples")]
        public void ThenItShouldHaveExamples(int p0)
        {
            int actual = _scenarioContext.Get<Int32>("example_count");
            actual.Should().Be(p0);
        }

        [When(@"(.*) more element is added")]
        public void WhenMoreElementIsAdded(int p0)
        {
            _scenarioContext.Add("no_of_elements_toadd",p0);
            for (int i = 0; i < p0; i++)
            {
                ((IAddRemoveOperations)page).AddElement().Wait();
            }
        }

        [Then(@"the added elements count is (.*)")]
        public void ThenTheAddedElementsCountIs(int p0)
        {
            int actual = ((IAddRemoveOperations)page).GetElementCount().Result;
            int expected = _scenarioContext.Get<Int32>("no_of_elements_toadd");
            actual.Should().Be(expected);
        }

        [Given(@"ABTesting is disabled")]
        public void GivenABTestingIsDisabled()
        {
           ((IABTestOperation)this.page).DisableABTest();
        }
    }

}


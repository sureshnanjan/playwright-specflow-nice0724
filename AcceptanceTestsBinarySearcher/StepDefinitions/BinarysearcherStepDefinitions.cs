using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySearcher;
namespace AcceptanceTestsBinarySearcher.StepDefinitions
{
    [Binding]
    internal class BinarysearcherStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        private BinarySearcherAUT aut;// = new BinarySearcherAUT();
        private int result;
        private Array input;
       

        public BinarysearcherStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            aut = new BinarySearcherAUT();
            
        }
        [Given(@"the input is (.*)")]
        public void GivenTheInputIs(string p0)
        {

            Console.WriteLine("Reading the input");
            //_scenarioContext.Pending();
            int ctr = 0;
            List<int> list = new List<int>();
            foreach (var item in p0.Split(","))
            {
               list.Add(int.Parse(item));
            }
            input = list.ToArray();
        }

        [When(@"I search for (.*)")]
        public void WhenISearchFor(int p0)
        {
            Console.WriteLine($"Searching for {p0}");
            //_scenarioContext.Pending();
            result = aut.doSearch(input,p0 );
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            //TODO: implement assert (verification) logic

            result.Should().Be(expected);
        }
    }
}

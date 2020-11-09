using System;
using TechTalk.SpecFlow;

namespace Library.Specs.StepDefinitions
{
    [Binding]
    public class ShelfSteps
    {
        [When(@"I send request for getting list of shelves to ""(.*)""")]
        public void WhenISendRequestForGettingListOfShelvesTo(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"list of shelves is displayed")]
        public void ThenListOfShelvesIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

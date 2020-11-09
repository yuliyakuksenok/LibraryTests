using System;
using TechTalk.SpecFlow;

namespace Library.Specs.StepDefinitions
{
    [Binding]
    public class ShelfSteps
    {
        [Given(@"API v(.*)")]
        public void GivenAPIV(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Client is authorized in librarian role")]
        public void GivenClientIsAuthorizedInLibrarianRole()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I send the request for adding a shelf to ""(.*)""")]
        public void WhenISendTheRequestForAddingAShelfTo(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I get the successful response with code '(.*)'")]
        public void ThenIGetTheSuccessfulResponseWithCode(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"new shelf was added")]
        public void ThenNewShelfWasAdded()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

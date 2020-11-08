using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Library.Specs.Drivers;

namespace Library.Specs.StepDefinitions
{
    [Binding]
    public class GettingWebAPISteps
    {
        private readonly WebDriver _webDriver;

        public GettingWebAPISteps(WebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Given(@"I have an API web page")]
        public void GivenIHaveAnAPIWebPage()
        {
            _webDriver.InitializeHttpClient();
        }
        
        [When(@"I send request to get API web '(.*)'")]
        public async Task WhenISendRequestToGetAPIWeb(string url)
        {
            await _webDriver.HttpClientGet(url);
        }

        [Then(@"the result should have status code '(.*)'")]
        public void ThenTheResultShouldHaveStatusCode(int expectedStatusCode)
        {
            _webDriver.CheckResponseStatusCode(expectedStatusCode);
        }
    }
}

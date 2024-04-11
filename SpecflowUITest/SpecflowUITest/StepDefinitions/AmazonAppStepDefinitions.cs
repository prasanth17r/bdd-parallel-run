using NUnit.Framework;
using PageRepository;

[assembly: Parallelizable(ParallelScope.Fixtures)]
namespace SpecflowUITest.StepDefinitions
{
    [Binding]
    public sealed class AmazonAppStepDefinitions
    {
        AmazonAppHomePage appHomePage;
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the app is launched")]
        public void TheAppIsLaunched()
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            const string APPURL = "https://www.amazon.in/";
            appHomePage = new AmazonAppHomePage();
            appHomePage.LaunchAppAndSearchAnItem(APPURL, "Books");

        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            throw new PendingStepException();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            throw new PendingStepException();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            throw new PendingStepException();
        }

        [AfterScenario]
        public void QuitSession()
        {
            if(appHomePage != null)
            {
                appHomePage.QuitApp();
            }
        }
    }
}
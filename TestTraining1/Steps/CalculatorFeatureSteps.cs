using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TestTraining1.Steps
{
    [Binding]
    public class CalculatorFeatureSteps
    {
        private double _n1;
        private double _n2;
        private double _answer;

        [Given(@"I have entered (.*) and (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(double n1, double n2)
        {
            _n1 = n1;
            _n2 = n2;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _answer = _n1 + _n2;
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(double expected)
        {
            Assert.AreEqual(_answer, expected);
        }
    }
}

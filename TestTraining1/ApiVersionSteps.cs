using System;
using System.Net;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;
using TestTraining1.Configuration;
using TestTraining1.Steps;

namespace TestTraining1
{
    [Binding]
    public class ApiVersionSteps : StepsBase
    {
        private RestRequest _request;
        private IRestResponse<dynamic> _response;

        [When(@"I request the version")]
        public void WhenIRequestTheVersion()
        {
            _request = new RestRequest();
            _request.Resource = Settings.ContentApiUrl + "/fashion/contentapi/v1/version";
        }
        
        [Then(@"I get an OK response")]
        public void ThenIGetAnOKResponse()
        {
            _response = Client.Execute<dynamic>(_request);
            Assert.AreEqual(HttpStatusCode.OK, _response.StatusCode);
        }
        
        [Then(@"I get a valid version response")]
        public void ThenIGetAValidVersionResponse()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

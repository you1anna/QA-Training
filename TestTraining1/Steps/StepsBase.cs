using System;
using RestSharp;
using TestTraining1.Configuration;
using TestTraining1.Utilities;

namespace TestTraining1.Steps
{
    public class StepsBase
    {
        public StepsBase()
        {
            Client = new DynamicRestClient(new Uri(Settings.ContentApiUrl));
            Response = new RestResponse<dynamic>();
        }
        protected DynamicRestClient Client { get; }
        protected IRestResponse<dynamic> Response { get; set; }
    }
}
    
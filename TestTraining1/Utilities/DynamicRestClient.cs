using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Deserializers;

namespace TestTraining1.Utilities
{
    public class DynamicRestClient : RestClient
    {
        public DynamicRestClient()
        {
            AddHandler("application/json", new DynamicJsonDeserializer());
        }

        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "0#")]
        public DynamicRestClient(Uri baseUrl)
            : base(baseUrl)
        {
            AddHandler("application/json", new DynamicJsonDeserializer());
        }

        private class DynamicJsonDeserializer : IDeserializer
        {
            public string DateFormat { get; set; }

            public string Namespace { get; set; }

            public string RootElement { get; set; }

            public T Deserialize<T>(IRestResponse response)
            {
                if (response == null)
                {
                    throw new ArgumentNullException("response");
                }

                return JsonConvert.DeserializeObject<dynamic>(response.Content);
            }
        }
    }
}
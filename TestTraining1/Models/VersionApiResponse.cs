using Newtonsoft.Json;

namespace TestTraining1.Models
{
    public class VersionApiResponse
    {
        [JsonProperty("Version")]
        public string Version { get; set; }
    }
}

using Newtonsoft.Json;
namespace Bellatrix.GoogleLighthouse
{
    public class LighthouseCoreAuditsDobetterwebUsesHttp2JsDisplayValue
    {
        [JsonProperty("values")]
        public Values Values { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }
}
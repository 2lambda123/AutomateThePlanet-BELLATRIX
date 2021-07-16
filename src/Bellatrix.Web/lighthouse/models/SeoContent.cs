using Newtonsoft.Json;
namespace Bellatrix.GoogleLighthouse
{
    public class SeoContent
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
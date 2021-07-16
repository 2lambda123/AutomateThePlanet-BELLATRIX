using Newtonsoft.Json;
namespace Bellatrix.GoogleLighthouse
{
    public class ScriptTreemapData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("score")]
        public object Score { get; set; }

        [JsonProperty("scoreDisplayMode")]
        public string ScoreDisplayMode { get; set; }

        [JsonProperty("details")]
        public Details Details { get; set; }
    }
}
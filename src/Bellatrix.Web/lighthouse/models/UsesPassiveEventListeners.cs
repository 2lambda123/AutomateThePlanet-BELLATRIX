using System.Collections.Generic;
using Newtonsoft.Json;
namespace Bellatrix.GoogleLighthouse
{
    public class UsesPassiveEventListeners
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("scoreDisplayMode")]
        public string ScoreDisplayMode { get; set; }

        [JsonProperty("details")]
        public Details Details { get; set; }
    }
}
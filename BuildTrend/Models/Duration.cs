using Newtonsoft.Json;

namespace BuildTrend.Models
{

    public class RecordDuration
    {
        [JsonProperty("agents_chatting_duration")]
        public int AgentsChattingDuration { get; set; }
        public int Count { get; set; }
        public int Duration { get; set; }
    }

    public class Duration
    {
        public string Name { get; set; }
        public Request Request { get; set; }
        public int Total { get; set; }
        public Dictionary<string, RecordDuration> Records { get; set; }
    }
}

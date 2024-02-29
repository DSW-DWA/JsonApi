using Newtonsoft.Json;

namespace BuildTrend.Models
{
    public class RecordResponseTime
    {
        public int Count { get; set; }
        [JsonProperty("response_time")]
        public double ResponseTime { get; set; }
    }

    public class ResponseTime
    {
        public string Name { get; set; }
        public Request Request { get; set; }
        public int Total { get; set; }
        public Dictionary<string, RecordResponseTime> Records { get; set; }
    }

}

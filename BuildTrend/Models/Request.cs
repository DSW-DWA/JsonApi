namespace BuildTrend.Models
{
    public class Filters
    {
        public string From { get; set; }
        public string To { get; set; }
        public Groups Groups { get; set; }
    }

    public class Groups
    {
        public List<int> Values { get; set; }
    }

    public class Request
    {
        public string Distribution { get; set; }
        public Filters Filters { get; set; }
    }
}

namespace BuildTrend.Models
{
    public class Tag
    {
        public string Name { get; set; }
        public Request Request { get; set; }
        public int Total { get; set; }
        public Dictionary<string, Dictionary<string, int>> Records { get; set; }
    }
}

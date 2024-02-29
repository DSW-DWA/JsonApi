namespace BuildTrend.Models
{
    public class RecordTotalChart
    {
        public int Total { get; set; }
    }

    public class TotalChats
    {
        public string Name { get; set; }
        public Request Request { get; set; }
        public int Total { get; set; }
        public Dictionary<string, RecordTotalChart> Records { get; set; }
    }
}

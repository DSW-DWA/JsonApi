namespace BuildTrend.Models
{

    public class RecordRating
    {
        public int? Bad { get; set; }
        public int Chats { get; set; }
        public int? Good { get; set; }
    }

    public class Rating
    {
        public string Name { get; set; }
        public Request Request { get; set; }
        public int Total { get; set; }
        public Dictionary<string, RecordRating> Records { get; set; }
    }

}

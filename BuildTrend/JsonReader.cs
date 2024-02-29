using BuildTrend.Models;
using Newtonsoft.Json;

namespace BuildTrend
{
    public class JsonReader
    {
        public Duration? GetDuration()
        {
            try
            {
                string json = File.ReadAllText("Data/Durations.json");
                return JsonConvert.DeserializeObject<Duration>(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public Rating? GetRatings()
        {
            try
            {
                string json = File.ReadAllText("Data/Ratings.json");
                return JsonConvert.DeserializeObject<Rating>(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public ResponseTime? GetResponseTime()
        {
            try
            {
                string json = File.ReadAllText("Data/ResponseTime.json");
                return JsonConvert.DeserializeObject<ResponseTime>(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public TotalChats? GetTotalChats()
        {
            try
            {
                string json = File.ReadAllText("Data/TotalCharts.json");
                return JsonConvert.DeserializeObject<TotalChats>(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public Tag? GetTags()
        {
            try
            {
                string json = File.ReadAllText("Data/Tags.json");
                return JsonConvert.DeserializeObject<Tag>(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }

}

using BuildTrend.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuildTrend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TableController : Controller
    {
        public JsonReader Reader { get; } = new JsonReader();

        [HttpGet("Duration")]
        public IActionResult GetDuration()
        {
            var result = Reader.GetDuration();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("Rating")]
        public IActionResult GetRating()
        {
            var result = Reader.GetRatings();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("ResponseTime")]
        public IActionResult GetResponseTime()
        {
            var result = Reader.GetResponseTime();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("Tag")]
        public IActionResult GetTag()
        {
            var result = Reader.GetTags();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("TotalChats")]
        public IActionResult GetTotalCharts()
        {
            var result = Reader.GetTotalChats();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }

}

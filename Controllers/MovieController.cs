using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace imagent_server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "This is the api/movie route";
        }

        [HttpGet("welcome/{name}/{numTimes:int}")]
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
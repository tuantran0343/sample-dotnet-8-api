using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.Controllers
{
    [ApiController]
    [Route(template: "content-v1")]
    public class ContentV1Controller : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public ContentV1Controller(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(template: "get-data")]
        public IEnumerable<string> Get()
        {
            List<string> p3 = ["asd", "1222", "666"];
            return p3;
        }
    }
}

public class SimpleModel
{
    public string Name { get; set; }
}
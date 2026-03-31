using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace SampleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy1", 
            "Hot", "Sweltering", "Scorching", "Weather", "Calm", "Please", "Mate",
            "Hondata",
            "Brandee", "Toyota", "Merc"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;

            CodeSmell();
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        private void CodeSmell()
        {
            int? varData = null;

            Console.WriteLine("Data => ", varData - 1);

            var connectionString = "Server=tcp:sql-prod-server.database.windows.net,1433;Initial Catalog=MyDatabase;Persist Security Info=False;User ID=myAdminUser;Password=&k9#mP2$qL8@xR5!vN3^zJ7*wB4%yT;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Min Pool Size=10;Max Pool Size=100;";
            var client = new SqlConnection(connectionString);
        }
    }
}

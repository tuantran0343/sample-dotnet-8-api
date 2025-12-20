using Bogus;
using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.Controllers
{

    [ApiController]
    [Route(template: "sample-api")]
    public class SampleController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public SampleController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(template: "users")]
        public IEnumerable<UserModel> GetMockFullUser()
        {
            var faker = new Faker<UserModel>()
                .RuleFor(u => u.Name, f => f.Name.FullName());

            var users = faker.Generate(3);  // Tạo 100 user fake

            return users;
        }
    }
}

public class UserModel
{
    public string Name { get; set; }
}

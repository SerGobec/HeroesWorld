using HeroesWorld.Domain.Repositories;
using HeroesWorld.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace HeroesWorld.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private IUserRepository _users;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUserRepository userRepository)
        {
            this._users = userRepository;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public int Get()
        {
            return this._users.GetAll().ToArray().Length;
        }

        [HttpGet]
        [Route("add")]
        public async Task<IActionResult> AddNew()
        {
            this._users.Add(new Domain.Entities.User()
            {
                Coints = 0,
                Diamonds = 0,
                Expirience = 3,
                Password = "sdsa",
                Role = Domain.Enums.UserRole.Admin,
                TelegramId = null,
                Username = "sd"
            });
            await this._users.SaveChanges();
            return StatusCode(200);
        }
    }
}
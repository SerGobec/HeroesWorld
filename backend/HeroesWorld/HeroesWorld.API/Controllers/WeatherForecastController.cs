using HeroesWorld.Application.User.Commands.CreateUser;
using HeroesWorld.Domain.Repositories;
using HeroesWorld.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HeroesWorld.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBaseWithMediatR
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private IUserRepository _users;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUserRepository userRepository, IMediator mediatR): base(mediatR)
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

            await this._mediatR.Send(new CreateUserCommand() { Username = "Melivor"});
            return Ok();
        }
    }
}
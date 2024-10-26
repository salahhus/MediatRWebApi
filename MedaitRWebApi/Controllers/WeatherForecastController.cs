using MedaitRWebApi.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MedaitRWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       
        private readonly IMediator _mediator;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IWeather> Get()
        {
           var response = await _mediator.Send(new WeatherMessage());
           return response;
        }
    }
}

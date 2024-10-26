using MedaitRWebApi.Interface;
using MediatR;

namespace MedaitRWebApi
{
    public class WeatherMessageHandler : IRequestHandler<WeatherMessage, IWeather>
    {
       private static readonly string[] Summaries = new[]
       {
           "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
       };

        public Task<IWeather> Handle(WeatherMessage request, CancellationToken cancellationToken)
        {
            return Task.FromResult<IWeather>(new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });
        }
    }
}

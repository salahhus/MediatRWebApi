using MedaitRWebApi.Interface;
using MediatR;

namespace MedaitRWebApi
{
    public class WeatherMessage : IRequest<IWeather>
    {
    }
}

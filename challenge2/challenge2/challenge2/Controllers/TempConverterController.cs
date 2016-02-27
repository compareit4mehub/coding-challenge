using challenge2.ServiceTempConverter;
using System;
using System.Web.Http;

namespace challenge2.Controllers
{
    public class TempConverterController : ApiController
    {
        ConvertTemperatureSoapClient _tempConverter = new ConvertTemperatureSoapClient();

        // GET: api/TempConverter/5
        public double Get(double temperature, string fromUnit, string toUnit)
        {
            TemperatureUnit from = (TemperatureUnit)Enum.Parse(typeof(TemperatureUnit), fromUnit);
            TemperatureUnit to = (TemperatureUnit)Enum.Parse(typeof(TemperatureUnit), toUnit);
            return _tempConverter.ConvertTemp(temperature, from, to);
        }
    }
}
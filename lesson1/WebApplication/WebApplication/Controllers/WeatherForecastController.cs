using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Org.BouncyCastle.Asn1.Cms;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public List<WeatherForecast> weathers;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet("read")]
        public IActionResult Weathers(List<WeatherForecast> weathers)
        {
            return Ok(weathers);
        }

        [HttpPut("save")]
        public IActionResult Saving(List<WeatherForecast> weathers)
        {
            return Ok(weathers);
        }

        
        [HttpDelete("delete")]
        public IActionResult Weathers(WeatherForecast weather)
        {
          
            var search = weather.Search(weather, weathers);
            for (int i = weathers.Count; i > 0; i++)
            {
                var weat = weathers[i];
                var nextweat = weathers[i + 1];
                
                if (search.Date == weat.Date && search.TemperatureC == weat.TemperatureC)
                {
                    weat.Date = nextweat.Date;
                    weat.TemperatureC = nextweat.TemperatureC;
                }
                
            }
            
            return Ok();
        }

        
        
        [HttpPatch("update")]
        public List<WeatherForecast> Update(DateTime time, int temp)
        {
            var search = new WeatherForecast(time, temp);
            var searched = search.Search(search,weathers);
            searched.Date = time;
            searched.TemperatureC = temp;
            for (int i = weathers.Count; i > 0; i++)
            {
                var weat = weathers[i];
                if (search.Date == weat.Date && search.TemperatureC == weat.TemperatureC)
                {
                    weat.Date = searched.Date;
                    weat.TemperatureC = searched.TemperatureC;
                }
            }
            
            return weathers;

        }
        
    }
}
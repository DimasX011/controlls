using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherMonitoring
{
    public class WeatherHolder
    {
        public List<WeatherForecast> weathers { get; set; }

        private static readonly string[] Summaries = new[]
        {
            "Freezing",  //заморозка
            "Bracing",   //крепкий мороз
            "Chilly",    //прохладно
            "Cool",     //холодно
            "Mild",     //мягкий мороз
            "Warm",     //тепло
            "Balmy",    //благоухающий
            "Hot",      //жарко
            "Sweltering", //изнуряющая жара
            "Scorching"    //палящая жара
        };
       
        
        public string Summariesverd(int temp)
        {
            if (temp < -50)
            {
                return Summaries[0];
            }
            else if (temp < -30)
            {
                return Summaries[1];
            }
            else if (temp < -20)
            {
                return Summaries[2];
            }
            else if (temp < -10)
            {
                return Summaries[3];
            }
            else if (temp < 0)
            {
                return Summaries[4];
            }
            else if (10 < temp)
            {
                return Summaries[5];
            }
            else if (20 < temp)
            {
                return Summaries[6];
            }
            else if (30 < temp)
            {
                return Summaries[7];
            }
            else if (40 < temp)
            {
                return Summaries[8];
            }
            else if (45 < temp)
            {
                return Summaries[9];
            }
            return null;
        }

        public WeatherHolder()
        {
            var rng = new Random();
            weathers = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = "",
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToList();
        }

        public void Add(int temp, string date)
        {

            var weather = new WeatherForecast
            {
                Date = date,
                TemperatureC = temp,
                Summary = Summariesverd(temp)
            };
            weathers.Add(weather);
        }

        public List<WeatherForecast> Get()
        {
            return weathers;
        }

        public WeatherForecast Search(int count)
        {
            for(int i=0; i< weathers.Count; i++)
            {
                if (weathers.Count == count)
                {
                    return weathers[i];
                }
                
            }
            return null;
        }
    }
}

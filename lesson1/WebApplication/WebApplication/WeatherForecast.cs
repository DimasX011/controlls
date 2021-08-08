using System;
using System.Collections.Generic;

namespace WebApplication
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);

        public string Summary { get; set; }

        public WeatherForecast(DateTime date, int temp)
        {
            Date = date;
            TemperatureC = temp;
        }

        public WeatherForecast Search(WeatherForecast weather, List<WeatherForecast> weathers)
        {
            for (int i = weathers.Count; i > 0; i++)
            {
                var weat = weathers[i];
                if (weather.Date == weat.Date && weather.TemperatureC == weat.TemperatureC)
                {
                    return weat;
                }

            }

            return weather;
        }

    }


}
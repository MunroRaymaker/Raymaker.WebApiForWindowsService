using System;

namespace ContosoWebApi
{
    public class WeatherForecast
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary
        {
            // -20 - 55
            get
            {
                int idx = 0;
                switch(TemperatureC)
                {
                    case var tmp when TemperatureC < -10: idx = 0; break;
                    case var tmp when TemperatureC < 0: idx = 1; break;
                    case var tmp when TemperatureC < 5: idx = 2; break;
                    case var tmp when TemperatureC < 10: idx = 3; break;
                    case var tmp when TemperatureC < 15: idx = 4; break;
                    case var tmp when TemperatureC < 20: idx = 5; break;
                    case var tmp when TemperatureC < 25: idx = 6; break;
                    case var tmp when TemperatureC < 30: idx = 7; break;
                    case var tmp when TemperatureC < 35: idx = 8; break;
                    case var tmp when TemperatureC >= 35: idx = 9; break;
                }
                return Summaries[idx];
            }
        }
    }
}

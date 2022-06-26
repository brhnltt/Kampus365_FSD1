using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    // convention-based routing
    // action-based routing
    // attribute-based routing
    // route prefix

    [ApiController]
    [Route("api/[controller]")] 
    public class WeatherForecastController : ControllerBase
    {
        private static List<string> Summaries = new List<string> {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        [HttpGet("/list-all-items")]   // http://localhost:[port]/list-all-items
        public List<WeatherForecast> List()
        {
            List<WeatherForecast> forecasts = new List<WeatherForecast>();
            
            foreach (var item in Summaries)
            {
                WeatherForecast forecast = new WeatherForecast()
                {
                    Date = DateTime.Now.AddDays(Random.Shared.Next(1,20)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = item
                };

                forecasts.Add(forecast);
            }

            return forecasts;

            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToList();
        }

        [HttpPost("add")]  // http://localhost:[port]/WeatherForecast/add
        public bool Create(string summary)
        {
            Summaries.Add(summary);
            return true;
        }

        [HttpPut("update-item")]   // http://localhost:[port]/WeatherForecast/update-item
        public bool Update(UpdateModel model)
        {
            int index = Summaries.IndexOf(model.OldSummary);
            Summaries[index] = model.NewSummary;

            return true;
        }

        [HttpDelete("remove")]    // http://localhost:[port]/WeatherForecast/remove
        public bool Delete(string summary)
        {
            //int index = Summaries.IndexOf(summary);
            //Summaries.RemoveAt(index);

            Summaries.Remove(summary);

            return true;
        }
    }

    public class UpdateModel
    {
        public string OldSummary { get; set; }
        public string NewSummary { get; set; }
    }
}
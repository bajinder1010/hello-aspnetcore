using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace HelloAspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
        {
            "testing", "Bracing", "Sydney", "fool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Bobby"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IOptions<MyConfig> config;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IOptions<MyConfig> config)
        {
            _logger = logger;
            this.config = config;
        }

        [HttpGet]
        public MyConfig Get()
        {
            var rng = new Random();
            return config.Value;
        }
    }
}

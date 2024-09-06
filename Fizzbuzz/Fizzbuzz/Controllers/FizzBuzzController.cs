using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Fizzbuzz.Models;

namespace Fizzbuzz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuzzFizzController : ControllerBase
    {
        private readonly ILogger<BuzzFizzController> _logger;
        private readonly ICalculation _calculation;

        public BuzzFizzController(ILogger<BuzzFizzController> logger, ICalculation calculation)
        {
            _logger = logger;
            _calculation = calculation;
        }

        [HttpGet]
        //public string Get()
        //{
        //    //var rng = new Random();
        //    //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    //{
        //    //    Date = DateTime.Now.AddDays(index),
        //    //    TemperatureC = rng.Next(-20, 55),
        //    //    Summary = Summaries[rng.Next(Summaries.Length)]
        //    //})
        //    //.ToArray();
        //    return "Start With Buzz & Fizz";
        //}
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to the default endpoint!");
        }

        [HttpPost("{Calculation}")]
        public string Calculation([FromBody] MixedDataModel model)
        {
            var result1 = _calculation.GetCalculationResults(model);
            return result1; ;
        }

        [HttpGet("{Calculation}")]
        public string Calculation()
        {
            return "Invalid Terms ";
        }
    }
}

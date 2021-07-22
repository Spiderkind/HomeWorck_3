using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperatureController : ControllerBase
    {
        private readonly Templist _holder;

        public TemperatureController(Templist holder)
        {
            _holder = holder;
        }
        [HttpGet]
        public IEnumerable<TemperatureList> List(DateTime Date1, DateTime Date2)
        {
            List<TemperatureList> OutList = _holder.AddToList(Date1, Date2);
            return Enumerable.Range(0, OutList.Count()).Select(index => new TemperatureList
            {
                Date = OutList[index].Date,
                Temperature = OutList[index].Temperature
            })
            .ToArray();
        }
        [HttpPost]
        public IActionResult Save([FromQuery] DateTime Date, float Temp)
        {
            _holder.Add(Date, Temp);
            return Ok();
        }
        [HttpPut]
        public IActionResult Change([FromQuery] DateTime Date, float Temp)
        {
            _holder.Update(Date, Temp);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(DateTime Date1, DateTime Date2)
        {
            _holder.Del(Date1, Date2);
            return Ok();
        }     
    }
}

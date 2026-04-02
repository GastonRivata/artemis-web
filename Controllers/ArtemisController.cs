using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Net.Http;
using System.Text.Json;


namespace ArtemisTracker.Controllers
{
    

    [ApiController]
    [Route("api/[controller]")]
    public class ArtemisController : ControllerBase
    {
        static int baseDistance = 10000;
        static DateTime start = DateTime.UtcNow;
        [HttpGet("distance")]
        public IActionResult GetDistance()
        {
            var seconds = (DateTime.UtcNow - start).TotalSeconds;

            var distance = baseDistance + (seconds * 1500); // velocidad fake

            return Ok(new
            {
                distance = (int)distance
            });
        }
    }


}
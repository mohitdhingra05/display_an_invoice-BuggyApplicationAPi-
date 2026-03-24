
using Microsoft.AspNetCore.Mvc;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetData()
        {
            string result = new string();
            if(result!=null) // will throw NullReferenceException
            {
                return Ok(new { message = "Data fetched" });
            }

            return BadRequest("No data");
        }
    }
}

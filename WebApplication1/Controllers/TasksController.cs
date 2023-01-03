using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class TasksController : ControllerBase

    {
        [HttpGet]
        public IActionResult Tasks()
        {
            var tasks = new string[] { "task 1", "task 2", "task 3" };
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult NewTasks()
        {
            
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTasks()
        {

            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTasks()
        {
            var somethinwentwrong = true;
            if (somethinwentwrong)
            {
                return BadRequest();
            }
            return Ok();


        }
    }
    
}


using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TaskAPI.Services;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase

    {
        private ITodoRepository _todoServices;

        public TodosController(ITodoRepository repository) {
            _todoServices = repository;
        }
        [HttpGet("{id?}")]



        public IActionResult Getodos(int ? id)
        {
            var myTodos = _todoServices.AllTodos();
            if (id is null) return Ok(myTodos);

            myTodos=myTodos.Where(t=> t.Id==id).ToList();
            return Ok(myTodos);

        }
    


    }
}


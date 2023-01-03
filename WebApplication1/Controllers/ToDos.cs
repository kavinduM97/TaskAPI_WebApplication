using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Collections.Generic;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase

    {
        private TodoServices _todoServices;

        public TodosController() {
            _todoServices =new TodoServices();
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


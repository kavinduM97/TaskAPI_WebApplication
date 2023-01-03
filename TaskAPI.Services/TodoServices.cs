using TaskAPI.Services;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class TodoServices : ITodoRepository
    {
        //Get todos

        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();
            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get books",
                Description = "Get some text",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            todos.Add(todo1);


            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get books",
                Description = "Get some text",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Completed
            };
            todos.Add(todo2);


            var todo3 = new Todo
            {
                Id = 3,
                Title = "Get books",
                Description = "Get some text",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            todos.Add(todo3);
            return todos;
        }
    }
}

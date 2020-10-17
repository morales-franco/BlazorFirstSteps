using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.ViewModels;

namespace TestApp.Services
{
    public class TodoService
    {
        private static IList<TodoVM> _todos = new List<TodoVM>() {
            new TodoVM
            {
                Title = "A",
                IsDone = true
            },
            new TodoVM
            {
                Title = "B",
                IsDone = false
            }
        };


        public Task<IList<TodoVM>> GetTodosAync()
        {
            var rng = new Random();
            return Task.FromResult(_todos);
        }
    }
}

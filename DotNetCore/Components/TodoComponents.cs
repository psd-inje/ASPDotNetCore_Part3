using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Components
{
    public class TodoComponents
    {
        
    }

    public class Todo2
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }

    }

    public class Todo2Context : DbContext
    {
        public Todo2Context(DbContextOptions<Todo2Context> options) : base(options)
        {
                
        }

        public DbSet<Todo2> Todos { get; set; }
    }

    public interface ITodo2Repository
    { 
    }

    public class Todo2Repository : ITodo2Repository
    {

    }

}

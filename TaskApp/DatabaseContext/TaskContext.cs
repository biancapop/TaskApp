using Microsoft.EntityFrameworkCore;
using TaskApp.Models;

namespace TaskApp.DatabaseContext
{
    public class TaskContext:DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
            
        }
        
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

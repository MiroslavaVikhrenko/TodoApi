using Microsoft.EntityFrameworkCore;
namespace TodoApi
{
    // DbContext class to use EF package
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options) : base(options) { }

        public DbSet<TodoItem> Todos { get; set; }
    }
}

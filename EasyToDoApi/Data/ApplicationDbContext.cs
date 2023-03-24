using Microsoft.EntityFrameworkCore;

namespace EasyToDoApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems => Set<TodoItem>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasData(
            new TodoItem() { Id = 1, Title = "Buy groceries", Done = false }, 
            new TodoItem() { Id = 2, Title = "Clean the house", Done = false }, 
           new TodoItem() { Id = 3, Title = "Take out the trash", Done = true },
            new TodoItem() { Id = 4, Title = "Do laundry", Done = true }
                );

          
           
        }
    }
}

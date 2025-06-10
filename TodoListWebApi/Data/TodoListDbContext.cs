using Microsoft.EntityFrameworkCore;

namespace TodoListWebApi.Data
{
    public class TodoListDbContext(DbContextOptions<TodoListDbContext> options) : DbContext(options)
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem
                {
                    Id = 1,
                    Title = "Buy groceries",
                    Description = "Milk, Bread, Eggs",
                    CreatedDate = new DateTime(2025, 5, 27, 14, 35, 24, 183, DateTimeKind.Utc).AddTicks(3064)
                },
                new TodoItem
                {
                    Id = 2,
                    Title = "Read book",
                    Description = "Read C# in Depth",
                    CreatedDate = new DateTime(2025, 5, 27, 14, 35, 24, 183, DateTimeKind.Utc).AddTicks(3436)
                },
                new TodoItem
                {
                    Id = 3,
                    Title = "Make a meal",
                    Description = "Cook daal. Make sure I have all ingredients",
                    CreatedDate = new DateTime(2025, 5, 27, 14, 35, 24, 183, DateTimeKind.Utc).AddTicks(3437)
                }
            );
        }
    }
}
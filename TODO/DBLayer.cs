using Microsoft.EntityFrameworkCore;

namespace TODOS
{
    public sealed class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }

        public Todo(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }

    public sealed class DBLayer : DbContext
    {
        public static DBLayer Instance { get; private set; } = new();

        public DbSet<Todo> Todos => Set<Todo>();

        public DBLayer()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source = todos.db");
        }
    }
}

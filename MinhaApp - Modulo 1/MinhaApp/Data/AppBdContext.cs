using Microsoft.EntityFrameworkCore;
using MinhaApp.Models;

namespace MinhaApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TodoModel>? Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}
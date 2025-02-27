using Microsoft.EntityFrameworkCore;

namespace Mission08_Team9.Models;

public class TaskContext : DbContext
{
    public TaskContext(DbContextOptions<TaskContext> options) : base(options)
    {
    }

    public DbSet<ToDoTask> Task { get; set; }
    public DbSet<Category> Category { get; set; }
}
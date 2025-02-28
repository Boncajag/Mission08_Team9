using Microsoft.EntityFrameworkCore;

namespace Mission08_Team9.Models;

public class TaskContext : DbContext
{
    public TaskContext(DbContextOptions<TaskContext> options) : base(options)
    {
    }

    public DbSet<ToDoTask> Tasks { get; set; }
    public DbSet<Category> Categories { get; set; }

    /*
    This is dummy data for testing purposes.
    */

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, CategoryName = "Home" },
            new Category { CategoryId = 2, CategoryName = "School" },
            new Category { CategoryId = 3, CategoryName = "Work" },
            new Category { CategoryId = 4, CategoryName = "Church" }
        );

        modelBuilder.Entity<ToDoTask>().HasData(
            // Quadrant 1 (Important/Urgent)
            new ToDoTask { TaskId = 1, TaskName = "Pay utility bills", DueDate = "2025-03-01", Quadrant = 1, CategoryId = 1, Completed = 0 },
            new ToDoTask { TaskId = 2, TaskName = "Finish IS 413 homework", DueDate = "2025-03-05", Quadrant = 1, CategoryId = 2, Completed = 0 },
            new ToDoTask { TaskId = 3, TaskName = "Call doctor for appointment", DueDate = "2025-03-02", Quadrant = 1, CategoryId = 1, Completed = 0 },
            new ToDoTask { TaskId = 4, TaskName = "Submit tax documents", DueDate = "2025-03-10", Quadrant = 1, CategoryId = 3, Completed = 0 },

            // Quadrant 2 (Important/Not Urgent)
            new ToDoTask { TaskId = 5, TaskName = "Prepare for work presentation", DueDate = "2025-03-10", Quadrant = 2, CategoryId = 3, Completed = 0 },
            new ToDoTask { TaskId = 6, TaskName = "Read book on leadership", DueDate = "2025-03-15", Quadrant = 2, CategoryId = 4, Completed = 0 },
            new ToDoTask { TaskId = 7, TaskName = "Exercise for 30 mins", DueDate = "2025-03-12", Quadrant = 2, CategoryId = 1, Completed = 0 },
            new ToDoTask { TaskId = 8, TaskName = "Plan summer vacation", DueDate = "2025-04-01", Quadrant = 2, CategoryId = 1, Completed = 0 },

            // Quadrant 3 (Not Important/Urgent)
            new ToDoTask { TaskId = 9, TaskName = "Reply to random emails", DueDate = "2025-03-06", Quadrant = 3, CategoryId = 3, Completed = 0 },
            new ToDoTask { TaskId = 10, TaskName = "Attend unnecessary meeting", DueDate = "2025-03-07", Quadrant = 3, CategoryId = 3, Completed = 0 },
            new ToDoTask { TaskId = 11, TaskName = "Fix minor bug in personal project", DueDate = "2025-03-08", Quadrant = 3, CategoryId = 2, Completed = 0 },
            new ToDoTask { TaskId = 12, TaskName = "Help friend move furniture", DueDate = "2025-03-09", Quadrant = 3, CategoryId = 1, Completed = 0 },

            // Quadrant 4 (Not Important/Not Urgent)
            new ToDoTask { TaskId = 13, TaskName = "Watch Netflix series", DueDate = "2025-03-20", Quadrant = 4, CategoryId = 1, Completed = 0 },
            new ToDoTask { TaskId = 14, TaskName = "Scroll through social media", DueDate = "2025-03-21", Quadrant = 4, CategoryId = 3, Completed = 0 },
            new ToDoTask { TaskId = 15, TaskName = "Rearrange bookshelf", DueDate = "2025-03-22", Quadrant = 4, CategoryId = 1, Completed = 0 },
            new ToDoTask { TaskId = 16, TaskName = "Play video games", DueDate = "2025-03-23", Quadrant = 4, CategoryId = 1, Completed = 0 }
        );
    }
}

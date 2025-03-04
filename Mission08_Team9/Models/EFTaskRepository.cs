namespace Mission08_Team9.Models;

public class EFTaskRepository : ITaskRepository
{
    private TaskContext _context;
    
    public EFTaskRepository(TaskContext temp)
    {
        _context = temp;
    }
    
    public List<ToDoTask> Tasks => _context.Tasks.ToList();
    public List<Category> Categories => _context.Categories.ToList();

    public void AddTask(ToDoTask toDoTask)
    {
        _context.Add(toDoTask);
        _context.SaveChanges();
    }
}
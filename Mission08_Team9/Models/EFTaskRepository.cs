namespace Mission08_Team9.Models;

public class EFTaskRepository : ITaskRepository
{
    private TaskContext _context;
    
    public EFTaskRepository(TaskContext temp)
    {
        _context = temp;
    }
    
    public List<ToDoTask> Task => _context.Task.ToList();
    public List<Category> Category => _context.Category.ToList();

    public void AddTask(ToDoTask toDoTask)
    {
        _context.Add(toDoTask);
        _context.SaveChanges();
    }
}
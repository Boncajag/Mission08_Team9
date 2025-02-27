namespace Mission08_Team9.Models;

public interface ITaskRepository
{
    List<ToDoTask> Task { get; }
    List<Category> Category { get; }
    
    public void AddTask(ToDoTask toDoTask);
}
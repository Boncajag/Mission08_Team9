namespace Mission08_Team9.Models;

public interface ITaskRepository
{
    List<ToDoTask> Tasks { get; }
    
    public void AddTask(ToDoTask toDoTask);
}
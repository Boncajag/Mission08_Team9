namespace Mission08_Team9.Models;

public interface ITaskRepository
{
    List<Task> Tasks { get; }
    
    public void AddTask(Task task);
}
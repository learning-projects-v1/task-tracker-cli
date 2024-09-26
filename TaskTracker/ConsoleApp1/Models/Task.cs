namespace ConsoleApp1.Models;


public class Task
{
    public int Id { get; set; }
    public string Description { get; set; }
    public TaskStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Task(int id, string description)
    {
        Id = id;
        Description = description;
        Status = TaskStatus.Todo;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }

    public override string ToString()
    {
        return $"[Id: {Id}, Description: {Description}, Status: {Status}, Created At: {CreatedAt}, Updated At: {UpdatedAt}]";
    }

}

public enum TaskStatus
{
    Todo,
    InProgress,
    Done
}
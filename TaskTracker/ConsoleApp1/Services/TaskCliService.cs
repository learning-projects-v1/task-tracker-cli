using ConsoleApp1.Models;
using System.Reflection;
using System.Text.Json;
namespace ConsoleApp1.Services;

public class TaskTrackerService
{
    private static readonly string currentDirectory = Directory.GetCurrentDirectory();
    private static readonly string filePath = Path.Combine(currentDirectory, "tasks.json"); // Use current directory
    private List<Models.Task> Tasks = new List<Models.Task>();


    private static TaskTrackerService _instance;
    private static readonly object _lock = new object();

    // Private constructor to prevent instantiation
    private TaskTrackerService() { }
    // Static method to provide global access to the single instance
    public static TaskTrackerService Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new TaskTrackerService();
                    }
                }
            }
            return _instance;
        }
    }


    public void LoadTasks()
    {
        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            if (!string.IsNullOrEmpty(jsonString))
            {
                Tasks = JsonSerializer.Deserialize<List<Models.Task>>(jsonString) ?? new List<Models.Task>();
            }
        }
    }
    
    public Models.Task GetTaskById(int id)
    {
        return Tasks.Find(x => x.Id == id);
    }
    public int AddTask(string description)
    {
        var allIds = Tasks.Select(task => task.Id);
        var id = allIds.Count() > 0 ? allIds.Max(): 1;
        var task = new Models.Task(id, description);
        Tasks.Add(task);
        SaveTasks();
        return id;
    }
    public void UpdateTask(Models.Task task)
    {
        var tTask = Tasks.Find(t => t.Id == task.Id);
        tTask = task;
        SaveTasks();
    }
    
    
   
    public void DeleteTask(Models.Task task)
    {
        Tasks.Remove(task);
        SaveTasks();
    }

    public void SaveTasks()
    {

        var jsonString = JsonSerializer.Serialize(Tasks, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, jsonString);
    }
    public List<Models.Task> GetAllTasks()
    {
        return Tasks;
    }
    public int FindMex(List<int> numbers)
    {
        numbers.Sort();
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] - numbers[i - 1] > 1) return numbers[i - 1] + 1;
        }
        return numbers.Count + 1;
    }

    public List<string> GetAllCommands()
    {
        var interfaceType = typeof(ACommandValidator);
        var assembly = Assembly.GetExecutingAssembly();
        var implementingTypes = assembly.GetTypes().Where(type => interfaceType.IsAssignableFrom(type) && !type.IsAbstract);
        var commands = new List<string>();
        foreach(var type in implementingTypes)
        {
            var instance = Activator.CreateInstance(type);
            var method = type.GetMethod("GetArgumentsFormat");
            if(method != null)
            {
                var args = (string)method.Invoke(instance, null);
                commands.Add(args);
            }
        }
        return commands;
    }
}

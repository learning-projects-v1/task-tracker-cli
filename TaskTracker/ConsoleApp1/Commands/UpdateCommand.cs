using ConsoleApp1.Models;
using ConsoleApp1.Services;

namespace ConsoleApp1.Commands;

public class UpdateCommand : ICommand
{
    string Message {  get; set; }
    ACommandValidator Validator { get; set; }
    public UpdateCommand(string message, ACommandValidator validator)
    {
        Message = message;
        Validator = validator;
    }
    public void Execute()
    {
        if (!Validator.Validate(Message)) {
            return;
        }

        var inputs = Message.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);

        int.TryParse(inputs[0], out var id);
        var tasks = TaskTrackerService.Instance.GetAllTasks();
        var task = tasks.Find(task => task.Id == id);
        if(task == null)
        {
            Console.WriteLine($"Task with id: {id} not found.");
            return;
        }
        task.Description = inputs[1];
        task.UpdatedAt = DateTime.Now;
        TaskTrackerService.Instance.UpdateTask(task);
        Console.WriteLine("task updated successfully!");
    }
}

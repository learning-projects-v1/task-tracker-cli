using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Commands;

public class MarkInProgressCommand : ICommand
{
    public string Message { get; set; }
    public ACommandValidator Validator { get; set; }
    public MarkInProgressCommand(string message, ACommandValidator validator)
    {
        Message = message;
        Validator = validator;
    }

    public void Execute()
    {
        if (!Validator.Validate(Message))
        {
            return;
        }
        var inputs = Message.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);
        int.TryParse(inputs[0], out int id);

        var task = TaskTrackerService.Instance.GetTaskById(id);
        if(task == null)
        {
            Console.WriteLine($"Task with id: {id} not found!");
            return;
        }
        task.Status = Models.TaskStatus.InProgress;
        TaskTrackerService.Instance.UpdateTask(task);
        Console.WriteLine($"Task [{id}] Marked as In Progress");
    }
}

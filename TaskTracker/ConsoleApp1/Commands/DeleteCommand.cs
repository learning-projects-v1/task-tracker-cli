using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands;

public class DeleteCommand : ICommand
{
    public string  Message { get; set; }
    ACommandValidator Validator { get; set; }
    public DeleteCommand(string message, ACommandValidator validator)
    {
        Message = message;
        Validator = validator;
    }
    public void Execute()
    {
        if (!Validator.Validate(Message)) return;
        int.TryParse(Message, out var id);
        var tasks = TaskTrackerService.Instance.GetAllTasks();
        var task = tasks.Find(task => task.Id == id);
        if(task == null)
        {
            Console.WriteLine($"Task with id {id} not found.");
            return;
        }
        TaskTrackerService.Instance.DeleteTask(task);
        Console.WriteLine($"Task {id} Deleted Successfully!");
    }
}

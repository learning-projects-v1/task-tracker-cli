using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using ConsoleApp1.Services;

namespace ConsoleApp1.Commands;

public class ListDoneCommand : ICommand
{
    public string Message { get; set; }
    ACommandValidator Validator { get; set; }
    public ListDoneCommand(string message, ACommandValidator validator)
    {
        Validator = validator;
        Message = message;
    }

    public void Execute()
    {
        if (!Validator.Validate(Message)) return;
        var tasks = TaskTrackerService.Instance.GetAllTasks().FindAll(task => task.Status == Models.TaskStatus.Done);
        if (!tasks.Any())
        {
            Console.WriteLine("No Task found for this command.");
            return;
        }
        tasks.ForEach(task => Console.WriteLine(task.ToString()));
    }
}

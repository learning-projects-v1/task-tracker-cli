using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using ConsoleApp1.Services;

namespace ConsoleApp1.Commands;

public class ListCommand : ICommand
{
    public string Message { get; set; }
    ACommandValidator Validator { get; set; }
    public ListCommand(string message, ACommandValidator validator)
    {
        Validator = validator;
        Message = message;
    }
    public void Execute()
    {
        if (!Validator.Validate(Message)) return;
        var tasks = TaskTrackerService.Instance.GetAllTasks();
        if(tasks.Count() == 0)
        {
            Console.WriteLine("Task list is empty. Add some tasks!");
        }
        tasks.ForEach(task => Console.WriteLine(task.ToString()));
    }
}

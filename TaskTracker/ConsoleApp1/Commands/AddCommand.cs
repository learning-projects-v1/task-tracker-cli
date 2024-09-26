using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands;
public class AddCommand : ICommand
{
    public string Message { get; set; }
    public ACommandValidator Validator { get; set; }
    public AddCommand(string message, ACommandValidator validator)
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
        var id = TaskTrackerService.Instance.AddTask(Message);
        Console.WriteLine($"Task {id} added");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1.Commands;

public class NoCommand : ICommand
{
    public string Message { get; set; }

    public NoCommand(string message)
    {
        Message = message;
    }

    public void Execute()
    {
        Console.WriteLine(Message);
    }
}
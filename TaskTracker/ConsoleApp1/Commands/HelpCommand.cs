using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands;

public class HelpCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("List of Available Commands:");
        var msgs = TaskTrackerService.Instance.GetAllCommands();
        msgs.ForEach(msg =>
        {
            Console.WriteLine(msg);
        });
    }
}

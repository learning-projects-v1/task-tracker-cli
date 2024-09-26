using ConsoleApp1.Commands;
using ConsoleApp1.CommandValidators;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services;

public static class CommandFactory
{
    public static ICommand GetCommand(string input)
    {
        if (string.IsNullOrEmpty(input)) return new NoCommand("Empty line.");
        var inputs = input.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);
        if(inputs.Length == 1)
        {
            inputs = inputs.Append("").ToArray();
            
        }
        switch (inputs[0].ToLower())
        {
            case "add":
                return new AddCommand(inputs[1], new AddCommandValidator());
            case "list":
                return new ListCommand(inputs[1], new ListCommandValidator());
            case "update":
                return new UpdateCommand(inputs[1], new UpdateCommandValidator());
            case "delete":
                return new DeleteCommand(inputs[1], new DeleteCommandValidator());
            case "mark-in-progress":
                return new MarkInProgressCommand(inputs[1], new MarkInProgressCommandValidator());
            case "mark-done":
                return new MarkDoneCommand(inputs[1], new MarkDoneCommandValidator());
            case "list-in-progress":
                return new ListInProgressCommand(inputs[1], new ListInProgressCommandValidator());
            case "list-to-do":
                return new ListToDoCommand(inputs[1], new ListToDoCommandValidator());
            case "list-done":
                return new ListDoneCommand(inputs[1], new ListDoneCommandValidator());
            case "help":
                return new HelpCommand();
            case "exit":
                return new ExitCommand();
            default:
                return new NoCommand($"No Command found with name {input}");
        }
    }
}

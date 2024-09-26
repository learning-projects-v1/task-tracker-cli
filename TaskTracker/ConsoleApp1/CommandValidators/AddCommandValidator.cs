using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CommandValidators;

public class AddCommandValidator : ACommandValidator
{
    public bool ValidateArguments(string Message)
    {
        return Message.StartsAndEndsWithQuotes();
    }

    public string GetArgumentsFormat()
    {
        return "[add] [\"Task Description\"]";
    }
}

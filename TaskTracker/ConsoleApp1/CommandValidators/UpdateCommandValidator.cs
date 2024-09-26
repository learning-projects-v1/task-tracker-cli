using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CommandValidators;

public class UpdateCommandValidator : ACommandValidator
{
    public string GetArgumentsFormat()
    {
        return "[Update] [id] [\"Task Description\"]";
    }

    public bool ValidateArguments(string Message)
    {
        var inputs = Message.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);
        return (inputs.Length == 2 && inputs[0].isInteger() && inputs[1].StartsAndEndsWithQuotes());
    }
}

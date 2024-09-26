using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CommandValidators;

public class MarkDoneCommandValidator : ACommandValidator
{
    public string GetArgumentsFormat()
    {
        return "[mark-done] [id]";
    }

    public bool ValidateArguments(string Message)
    {
        return int.TryParse(Message, out _);
    }
}

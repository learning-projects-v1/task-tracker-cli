using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CommandValidators;

public class ListInProgressCommandValidator : ACommandValidator
{
    public string GetArgumentsFormat()
    {
        return "[list-in-progress]";
    }

    public bool ValidateArguments(string Message)
    {
        return string.IsNullOrEmpty(Message);
    }
}

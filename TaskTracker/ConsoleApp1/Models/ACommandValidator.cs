using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models;

public interface ACommandValidator
{
    public bool Validate(string message)
    {
        if (!ValidateArguments(message))
        {
            Console.WriteLine("Invalid input format. Please use format: " + GetArgumentsFormat());
            return false;
        }
        return true;
    }
    public abstract bool ValidateArguments(string Message);
    public abstract string GetArgumentsFormat();

}

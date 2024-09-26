using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CommandValidators
{
    public class ListDoneCommandValidator : ACommandValidator
    {
        public string GetArgumentsFormat()
        {
            return "[list-done]";
        }

        public bool ValidateArguments(string Message)
        {
            return string.IsNullOrEmpty(Message);
        }
    }
}

using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Commands;

public class ExitCommand : ICommand
{
    public void Execute()
    {
      System.Environment.Exit(0);
    }
}

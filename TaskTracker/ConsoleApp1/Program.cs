using ConsoleApp1.Services;

Console.WriteLine("Hello, World!");

TaskTrackerService.Instance.LoadTasks();


while (true)
{
    var input = Console.ReadLine();
    var command = CommandFactory.GetCommand(input);
    command.Execute();
}

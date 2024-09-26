# Task Tracker CLI

A simple command-line tool to track tasks, built using .NET.

## Getting Started

Follow these steps to clone the repo, navigate to the project, and run it.

### Running The App

1. First, clone this repository to your local machine using Git:
git clone https://github.com/your-username/task-tracker-cli.git
2. Run the app
go to task-tracker-cli/TaskTracker. You can use cd task-tracker-cli/TaskTracker
  dotnet clean
  dotnet build
  dotnet run --project ConsoleApp1
3. Using Commands
   You can write 'help' to know available commands.
List of all available commands:  
  [add] ["Task Description"]  
  [delete] [id]  
  [list]  
  [list-done]  
  [list-in-progress]  
  [list-to-do]  
  [mark-done] [id]  
  [mark-in-progress] [id]  
  [Update] [id] ["Task Description"]  
eg. add "Attend Contest 231"



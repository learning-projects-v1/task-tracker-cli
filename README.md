# Task Tracker CLI
Sample solution for the task-tracker challenge from [roadmap.sh](https://roadmap.sh/projects/task-tracker)

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

### # add a task
  - [add] ["Task Description"]
### # update a task
  - [Update] [id] ["Task Description"]
### # delete a task
  - [delete] [id]
### # mark as done or in progress  
  - [mark-done] [id]  
  - [mark-in-progress] [id]
### # list tasks
  - [list]  
  - [list-done]  
  - [list-in-progress]  
  - [list-to-do]

eg. add "Attend Contest 231"



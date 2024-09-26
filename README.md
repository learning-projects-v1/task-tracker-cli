# Task Tracker CLI
Sample solution for the task-tracker challenge from [roadmap.sh](https://roadmap.sh/projects/task-tracker)

## Getting Started
Follow these steps to clone the repo, navigate to the project, and run it.

go build -o task-tracker
./task-tracker --help # To see the list of available commands

# To add a task
./task-tracker add "Buy groceries"

# To update a task
./task-tracker update 1 "Buy groceries and cook dinner"

# To delete a task
./task-tracker delete 1

# To mark a task as in progress/done/todo
./task-tracker mark-in-progress 1
./task-tracker mark-done 1
./task-tracker mark-todo 1

# To list all tasks
./task-tracker list
./task-tracker list done
./task-tracker list todo
./task-tracker list in-progress

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

  - [add] ["Task Description"]  
  - [delete] [id]  
  - [list]  
  - [list-done]  
  - [list-in-progress]  
  - [list-to-do]  
  - [mark-done] [id]  
  - [mark-in-progress] [id]  
  - [Update] [id] ["Task Description"]  

eg. add "Attend Contest 231"



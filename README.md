# TodoPracties
TODO List Console Application
A simple, interactive console-based TODO manager built in C# as part of the Ultimate C# Masterclass Assignment.

📋 Overview
This application allows users to manage their TODO items through a command-line interface. Each TODO consists of a unique description that can be added, viewed, or removed from the collection.

✨ Features
Add TODOs: Create new TODO items with unique descriptions
View TODOs: Display all current TODO items in a numbered list
Remove TODOs: Delete specific TODO items by index
Input Validation: Handles empty inputs, duplicates, and invalid selections
Case-Insensitive Commands: Accepts both uppercase and lowercase menu options
🚀 Getting Started
Prerequisites
.NET Framework or .NET Core/5+
Any C# IDE (Visual Studio, VS Code, Rider, etc.)
Installation
Clone the repository:
bash
git clone https://github.com/yourusername/todo-console-app.git
Navigate to the project directory:
bash
cd todo-console-app
Build the project:
bash
dotnet build
Run the application:
bash
dotnet run
🎮 Usage
When you start the application, you'll see the main menu:

Hello!
What do you want to do?
[S]ee all TODOs
[A]dd a TODO
[R]emove a TODO
[E]xit
Menu Options
[S] See all TODOs
Displays all current TODO items in a numbered list
Shows "No TODOs have been added yet." if the list is empty
Example output:

1. Order a cake for the birthday party.
2. Buy train tickets for the weekend.
3. Take Lucky to the vet.
[A] Add a TODO
Prompts for a TODO description
Validates that the description is not empty
Ensures the description is unique
Confirms successful addition
Example interaction:

Enter the TODO description:
> Buy groceries
TODO successfully added: Buy groceries
[R] Remove a TODO
Shows the current list of TODOs with indices
Prompts for the index of the TODO to remove
Validates the input and removes the selected item
Confirms successful removal
Example interaction:

Select the index of the TODO you want to remove:
1. Buy groceries
2. Walk the dog
> 1
TODO removed: Buy groceries
[E] Exit
Closes the application
🔧 Input Validation
The application handles various input scenarios:

Empty inputs: Prompts the user to try again
Invalid menu options: Shows "Incorrect input" message
Duplicate TODO descriptions: Prevents adding non-unique items
Invalid indices: Validates removal selections
Case sensitivity: Accepts both uppercase and lowercase commands
🏗️ Project Structure
TodoConsoleApp/
├── Program.cs          # Main application entry point
├── TodoManager.cs      # Core TODO management logic
├── README.md          # Project documentation
└── TodoConsoleApp.csproj # Project configuration
🧪 Example Session
Hello!
What do you want to do?
[S]ee all TODOs
[A]dd a TODO
[R]emove a TODO
[E]xit
> a

Enter the TODO description:
> Buy milk
TODO successfully added: Buy milk

What do you want to do?
[S]ee all TODOs
[A]dd a TODO
[R]emove a TODO
[E]xit
> s

1. Buy milk

What do you want to do?
[S]ee all TODOs
[A]dd a TODO
[R]emove a TODO
[E]xit
> e
🤝 Contributing
This is an educational project, but contributions are welcome! Please feel free to:

Fork the repository
Create a feature branch
Make your changes
Submit a pull request
📝 License
This project is part of the Ultimate C# Masterclass and is intended for educational purposes.

🎯 Learning Objectives
This project demonstrates:

Console I/O operations
Input validation and error handling
Collection management (List operations)
Control flow and menu-driven programming
String manipulation and comparison
User experience design in console applications
Built with ❤️ as part of the Ultimate C# Masterclass


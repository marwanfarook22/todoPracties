// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

var Todo = new List<string>();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(" Hello There In Our Todo Project !");
Console.ForegroundColor = ConsoleColor.Cyan;
bool ExitLoop = true;
while (ExitLoop)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    var UserInput = Console.ReadLine();
    switch (UserInput)
    {
        case "e":
        case "E":
            ExitLoop = false;
            break;
        case "A":
        case "a":
            addCase();
            break;
        case "S":
        case "s":
            SeeTodos();
            break;
        case "R":
        case "r":
            RemoveTodos();
            break;
        default:
            InvalidIndexMessage();
            break;
    }
}
void SeeTodos()
{
    if (Todo.Count == 0)
    {
        Console.WriteLine(" No Todo To Show Yet ");
        return;
    }
    for (int i = 0; i < Todo.Count; i++)
    {
        Console.WriteLine($"{i + 1}.{Todo[i]}");
    }
}
void addCase()
{

    string describtion;
    do
    {
        Console.WriteLine("Add New Describiton");
        describtion = Console.ReadLine();
    }
    while (!describtionValidition(describtion));
    Console.WriteLine("The Todo Just Add Is " + describtion);
    Todo.Add(describtion);
}


void RemoveTodos()
{
    int index;
    if (Todo.Count() == 0)
    {
        EmptyMessage();
        return;
    }
    do
    {

    }
    while (!removingmethod(out index));
    RemovingConfirmaition(index - 1);
}

void RemovingConfirmaition(int index)
{

    Console.WriteLine("The Todo you Remove Is : " + Todo[index]);
    Todo.Remove(Todo[index]);
}

static void EmptyMessage()
{
    Console.WriteLine("Should Not Be Empety");

}

static void InvalidIndexMessage()
{
    Console.WriteLine("Invlaid Index You Choosen");
}

bool describtionValidition(string Description)
{
    if (Description == "")
    {
        EmptyMessage();
        return false;
    }
    if (Todo.Contains(Description))
    {
        Console.WriteLine("The description must be uniqe");
        return false;
    }




    return true;
}

bool removingmethod(out int index)
{
    Console.WriteLine("Select the index of the TODO you want to remove:");
    SeeTodos();
    var SelectedTodo = Console.ReadLine();
    if (SelectedTodo == "")
    {
        index = 0;
        Console.WriteLine("You should Choose Index");
        return false;
    }
    if (int.TryParse(SelectedTodo, out index) && index >= 1 && index <= Todo.Count())
    {
        return true;
    }
    InvalidIndexMessage();
    return false;

}

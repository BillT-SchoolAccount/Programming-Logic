using System.Runtime.CompilerServices;

//Part 1: Operator Practice
int a = 10, b = 5, c = 15;
string q1 = "a > b: ";
string q2 = "a < c: ";
string q3 = " a > b and a > c: ";
string q4 = "a > b or a > c: ";


Console.WriteLine((q1) + (a > b));
Console.WriteLine((q2) + (a < c));
Console.WriteLine((q3) + (a > b && a > c));
Console.WriteLine((q4) + (a > b || a > c));

//Part 2: bool variable

bool isRaining = true;
bool haveUmbrella = false;

if (isRaining && !haveUmbrella)
    Console.WriteLine("Take an Umbrella!");
else
    Console.WriteLine("You're good to go!");

//Part 3: Conditional Logic- Movie Ticket Prices
Console.WriteLine("What is your age?");
int age = Convert.ToInt32(Console.ReadLine());
if (age < 5)
{
    Console.WriteLine("Ticket is free!");
}
else if (age < 12)
{
    Console.WriteLine("Child Ticket: $5");
}
else if (age < 64)
{
    Console.WriteLine("Standard Ticket: $10");
}
else
{
    Console.WriteLine("Senior Ticket: $6");
}

//Part 4: Using a Switch Statement
Console.WriteLine("What day of the week is it?(enter a number 1-7)");
int day = Convert.ToInt32(Console.ReadLine());
switch(day)
{
    case 1: 
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
        break;
}        

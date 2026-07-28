namespace Lab4;
using System;
class Car
{
    public string model;
    public string color;
    public int year;
    public int nummiles;

    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }
    //Method to start the car 
    public void Start()
    {
        Console.WriteLine("The car has started.");
    }
    //Method to drive the car
    public void Drive()
    {
        Console.WriteLine("The car drove " + nummiles + " miles.");
    }
    public void GetDescription()
    {
        string z = year + " " + color + " " + model;
        Console.WriteLine(z);
    }
    public void Repaint(string color)
    {
        Console.WriteLine("The car has been repainted to " + color);
    }
}

class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;
        myCar.nummiles = 50; // Assigning a value to nummiles
    
        myCar.Display(); // Calling the Display method
        myCar.Start(); // Calling the Start method
        myCar.Drive(); // Calling the Drive method
        myCar.GetDescription(); // Calling the GetDescription method
        myCar.Repaint("Red"); // Calling the Repaint method   
    }
}

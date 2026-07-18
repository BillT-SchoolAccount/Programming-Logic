using System.Diagnostics;

namespace Lab1;

internal class NewBaseType
{
    static void Main(string[] args)
    {
        //Step 1: Comments
       //Given name of student is Bill Tarczy
        //Introduction to class IT 1050
        //Step 2: Basic Output
        Console.WriteLine("My name is Bill Tarczy.");
        //course title
        Console.WriteLine("This is IT-1050 Programming Logic.");
        //Step 3: Declare and Use variables
        //favorite number
        int favnumber = 7;
        Console.WriteLine("My favorte number is " + favnumber);
        //favorite programming language
        string favproglanguage = "R programming language";
        Console.WriteLine("My favorite computer language is " + favproglanguage);
        //number of programs written
        double numprogwritten = 2;
        Console.WriteLine("I have written about " + numprogwritten + " partial programs before this.");
        // i do or do not have programming experince
        bool progexperience = false;
        Console.WriteLine("Do I have programming experience? " + progexperience);
        //Step 4: Use Constants
        const string SchoolName = "Cuyahoga Community College";
        Console.WriteLine("The name of my school is " + SchoolName);
        //Step 5: Type Casting
        //Convert double to int
        double numdouble = 9.78;
        int numint = (int) numdouble;
        Console.WriteLine("The double value is: " + numdouble);
        Console.WriteLine("The double value converted to Int is: " + numint);
        //convert int to a string
        int numstring = numint;
        Console.WriteLine("The int value converted to string is: " + Convert.ToString(numstring));
        //convert bool to string
        bool boolvar = true;
        Console.WriteLine("The bool variable is: " + boolvar);
        Console.WriteLine("The bool variable converted to string is: " + Convert.ToString(boolvar));
        //Step 6:User input and type conversion
        Console.WriteLine("What is your name? ");
        string namestring = Console.ReadLine();
        Console.WriteLine("How old are you? ");
        string agestring = Console.ReadLine();
        Console.WriteLine(" Your name is " + namestring + " and you are " + Convert.ToInt32(agestring) + " years old.");
        //Step 7: Arithmetic Operators
        float x = 3;
        float y = 5;
        Console.WriteLine("The x variable value is: " + x);
        Console.WriteLine("The y variable value is: " + y);
        x = x += 10; x -= 2; x *= 3; x /= 2; 
        Console.WriteLine("x + 10 - 2 * 3 / 2 = " + x);
        x %= 2;
        Console.WriteLine("And the remainder is " + x);
        y = y += 10; y -= 2; y *= 3; y /= 2; 
        Console.WriteLine("y + 10 - 2 * 3 / 2  = " + y);
        y %= 2;
        Console.WriteLine("And the remainder is " + y);
        //Step 8: Floaqting point precision
        float floatnum = 1.123456789F;
        double doublenum = 1.123456789D;
        Console.WriteLine("The float variable number is displayed as " + floatnum);
        Console.WriteLine("The double variable is displayed as " + doublenum);
        //Step 9: Increment and Decrement
        int z, z1;
        z = z1 = 10;
        Console.WriteLine("z variable = " + z);
         z = z ++;
         Console.WriteLine("Adding an increment of 1 to z = " + z);
         z1 = z --;
         Console.WriteLine("Subtracting a decrement of 1 to z = " + z);





        
        


    {
        
    }    }

}

internal class Program : NewBaseType
{
}

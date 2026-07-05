namespace Lab1;

internal class NewBaseType
{
    static void Main(string[] args)
    {
        //Introduction to class
        //name of student
        Console.WriteLine("My name is Bill Tarczy.");
        //course title
        Console.WriteLine("This is IT-1050 Programming Logic.");
        //favorite number
        int favnumber = 7;
        Console.WriteLine("My favorte number is " + favnumber);
        //favorite programming language
        string favproglanguage = "R programming language";
        Console.WriteLine("My favorite computer language is " + favproglanguage);
        //number of program written
        double numprogwritten = 2;
        Console.WriteLine("I have written about " + numprogwritten + " partial programs before this.");
        // i do or do not have programming experince
        bool progexperience = false;
        Console.WriteLine("Do I have programming experience? " + progexperience);
    {
        
    }    }

}

internal class Program : NewBaseType
{
}

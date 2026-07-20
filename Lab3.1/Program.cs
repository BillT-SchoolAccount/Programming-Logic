namespace Lab3._1;

class Program
{
    static void Main(string[] args)
    {       // Problem 1: Simple for loop
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Problem 2: Even numbers from 1 to 20 (Using modulus operator)
        for (int j = 1; j <= 20; j++)
        {
            if (j % 2 == 0)
            {
                Console.WriteLine(j);
            }
        }

        // Problem 3: While loop condition
        int k = 5;
        while (k > 0)
        {
            Console.WriteLine(k);
            k--;
        }
        
        // Problem 4: While Loop (multiples of 10 from 10 to 1000)
        int l = 10;
            while (l <= 1000)
      {
          Console.WriteLine(l);
          l += 10;
      }

       //Problem 5: Seasons of the Year
       string[] seasons = {"Spring", "Summer", "Autumn", "Winter"};
      foreach (string season in seasons)
      {
          Console.WriteLine(season);
      }
    // Problem 6: Days of Week 1-7
      string[] daysofweek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
    Console.WriteLine("Please enter a number 1-7 to get the corresponding day of the week: ");
    int input = int.Parse(Console.ReadLine());
    
    if (input < 1 || input > 7)
    {
        Console.WriteLine("Invalid input. Please enter a number 1-7.");
    }
    else
    {
        Console.WriteLine("The corresponding day of the week is: " + daysofweek[input - 1]);
    }

    // Problem 7: Favorite Books and Authors
        string[] BookTitles = {"A Brief History of Time", "The Book of Mormon", "The Pentateuch"};
        string[] Authors = {"Stephen Hawking", "Joseph Smith", "Moses"};
    for (int i = 0; i < BookTitles.Length; i++)
    {
        Console.WriteLine("Book: " + BookTitles[i] + ", Author: " + Authors[i]);
    }
    // Problem 8: Temperature Tracker
     int[] temp = {74, 68, 88, 93, 95};
    {
        Array.Sort(temp);
    for (int i = 0; i < temp.Length; i++)
    {
        Console.WriteLine("Temperature: " + temp[i]);
    }
    
    Console.WriteLine("The lowest temperature is " + temp.Min());
    Console.WriteLine("The highest temperature is " + temp.Max());
    }

    // Problem 9: Reverse Countdown
    int[] numbers = {5, 4, 3, 2, 1};
    Console.WriteLine("An array of numbers:");
    Array.Sort(numbers);
    for (int j = 0; j < numbers.Length; j++)
    {
    Console.WriteLine(numbers[j]);
    }
    Console.WriteLine("Numbers in reverse order:");
    Array.Reverse(numbers);
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }

    
    }
}

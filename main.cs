using System;

class Program
{
    public static void Main()
    {
        // Input
        Console.Write("Enter the number of parking spaces: ");
        int parkingSpaces = int.Parse(Console.ReadLine());
        string yesterday = Console.ReadLine();
        string today = Console.ReadLine();

        int counter = 0; // Counter used to count parking spaces occupied both days

        // Loop through both strings
        for (int i = 0; i < parkingSpaces; i++)
        { 
            if (yesterday[i] == today[i] && today[i] == 'C')
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}

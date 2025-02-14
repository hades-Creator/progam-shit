using System;

class Program
{
    static void Main()
    {
        // Create an array to store 5 names
        string[] names = new string[5];

        Console.WriteLine("Please enter 5 names:");

        // Loop to get 5 names from the user
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"Enter name {i + 1}: ");
            names[i] = Console.ReadLine();
        }

        Console.WriteLine("\nThe names you entered are:");

        // Loop to display the names entered by the user
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
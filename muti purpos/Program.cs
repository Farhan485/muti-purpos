using System;

class StoreNameAndAge
{
    static void Main()
    {
        string name;
        int age;

        Console.WriteLine("=== Store and Display Name & Age ===");

        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        Console.Write("Enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("=== Output ===");
        Console.WriteLine($"Your Name: {name}");
        Console.WriteLine($"Your Age: {age}");

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

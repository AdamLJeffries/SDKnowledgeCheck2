using System;
using System.Collections.Generic;

internal static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many cats do you want to add? ");
        var numberofRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Cat>();
        for (int i = 0; i < numberofRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()

            var cat = new Cat();
            recordList.Add(cat);

            Console.WriteLine("Name your cat!");
            cat.Name = Console.ReadLine();
            Console.WriteLine($"Adding {cat.Name} to the record.");

            Console.WriteLine("Enter the value for number of legs ");
            cat.Legs = Console.ReadLine();
            Console.WriteLine($"Adding {cat.Legs} number of legs to {cat.Name}'s record.");

            Console.WriteLine("Enter the value for number of tails.");
            cat.Tail = Console.ReadLine();
            Console.WriteLine($"Adding {cat.Tail} number of tails to {cat.Name}'s record.");

            cat.makeNoise();

        }

        Console.WriteLine("Our record has the following information:");
        foreach (var cat in recordList)
        {
            Console.WriteLine($"{cat.Name}: Has {cat.Tail} tail and {cat.Legs} legs");

            Console.WriteLine("\r\nAn exposed belly is an invitation to pet. 50% chance you are welcomed to experience");
            Console.WriteLine("the feeling of dancing with baby angels in the fluffy clouds of heaven!");
            Console.WriteLine("\r\nEqual chance you are not permitted and met with a storm of razor sharp claws and teeth");
            Console.WriteLine("in the fur-ocious depths of cat hell.");

            Console.WriteLine("\r\nPet carefully my friends!\r\n");
        }
    }

    public class Animal
    {
        public string Legs { get; set; }

        public void makeNoise()
        {
            Console.WriteLine("Your animal makes this noise .");
        }
    }

    public class Cat : Animal
    {
        public string Tail { get; set; }
        public string Name { get; set; }

        public void makeNoise()
        {
            Console.WriteLine("Meow!");
        }
    }
}
using System;

namespace Day1Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the Identity stealer!");

            Console.WriteLine("Can you give me your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Can you give me your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Can you give me your hometown?");
            string homeTown = Console.ReadLine();

            Console.WriteLine("Can you give me your favorite food?");
            string favFood = Console.ReadLine();

            Console.WriteLine($"Your name is {name}. Your age is {age}. Your hometown is {homeTown}. Your favorite food is {favFood}.");
        }
    }
}

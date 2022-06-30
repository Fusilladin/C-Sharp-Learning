using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change the appearance
            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            
            // Get a conversation going
            Console.WriteLine("Hello, what's your name?");
            Console.ReadLine(); // Ask for user input
            
            Console.WriteLine("My name is RX-9020. I am an AI.");
            Console.WriteLine("What is your favorite color?");
         
            Console.ReadLine();
            Console.WriteLine("Cool! Mine is blue.");
         
            Console.ReadKey();
        }
    }
}
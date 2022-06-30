using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, Tickets are $5. Please insert cash.");
            
            int cash = Convert.ToInt32(Console.ReadLine());
            
            if(cash<5)
            {
                Console.WriteLine("That's not enough money.");
            }
            else if(cash>5)
            {
                int change = cash - 5;
                Console.WriteLine("Your change is $" + change + " and here is your ticket.");
            }
            else
            {
                Console.WriteLine("Here is your ticket.");
            }
            Console.ReadKey();
        }
    }
}

//////////////

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;
            
            Console.Write("Please input age: ");
            age = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Please input height (cm): ");
            height = Convert.ToInt32(Console.ReadLine());
            
            if(age >= 18 && height >= 160){ // pipes || is or , andsign && is and
                Console.WriteLine("You can enter!");
            }
            else{
                Console.WriteLine("You don't meet the requirements.");
            }
            
            Console.ReadKey();
        }
    }
}

/////////////////


using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            
            string userName = Console.ReadLine();
            
            Console.WriteLine("Hello " + userName + ", nice to meet you!");
         
            Console.ReadKey();
        }
    }
}
/////////////

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double num01;
            double num02;
            
            Console.WriteLine("SIMPLE MULTIPLICATION CALCULATOR\n");
            Console.Write("Input a number: ");
            num01 = Convert.ToDouble(Console.ReadLine());
            
            
            Console.Write("Input a second number: ");
            num02 = Convert.ToDouble(Console.ReadLine());
            
            double result = num01 * num02;
            Console.WriteLine("\nThe result is: " + result);
         
            Console.ReadKey();
        }
    }
}

////////////////

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double num01;
            double num02;
            double num03;
            
            Console.WriteLine("NUMBER AVERGING\n");
            Console.Write("Input a number: ");
            num01 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Input a second number: ");
            num02 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input a third number: ");
            num03 = Convert.ToDouble(Console.ReadLine());
            
            double numSum = num01 + num02 + num03;
            double result = numSum / 3;
            Console.WriteLine("\nThe result is: " + result);
         
            Console.ReadKey();
        }
    }
}
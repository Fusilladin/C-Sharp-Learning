using System;

namespace NumSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Multiply(3,8);
            Multiply(7,13);
            Multiply(11,5);
            
            // Wait before closing
            Console.ReadLine();
            
        }
        
        static void Multiply (int num01, int num02)
        {
            int result = num01 * num02;
            Console.WriteLine("The result is: " + result);
        }
    }
}


//-------------------------------


using System;

namespace NumSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int result = Multiply(3,8);

            Console.WriteLine("The result is: " + result);
            
            if (result % 2 == 0)
            {
                Console.WriteLine(result + " is an even number!");
            } else
            {
                Console.WriteLine(result + " is an uneven number!");
            }
            
            // Wait before closing
            Console.ReadLine();
            
        }
        
        static int Multiply (int num01, int num02)
        {
            int result = num01 * num02;
            return result;
        }
    }
}
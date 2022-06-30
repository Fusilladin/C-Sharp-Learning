using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            
            Console.Write("10 * 2 + 3 = ");
            num1 = Convert.ToInt32(Console.ReadLine());
            if(num1 == 23){
                Console.WriteLine("Correct!");
            }
            else{
                Console.WriteLine("Incorrect!");
            }
            Console.Write("25 * 7 - 14 = ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if(num2 == 161){
                Console.WriteLine("Correct!");
            }
            else{
                Console.WriteLine("Incorrect!");
            }
            Console.Write("12 / 4 + 12 = ");
            num3 = Convert.ToInt32(Console.ReadLine());
            if(num3 == 15){
                Console.WriteLine("Correct!");
            }
            else{
                Console.WriteLine("Incorrect!");
            }
           
            
            
            Console.ReadKey();
        }
    }
}
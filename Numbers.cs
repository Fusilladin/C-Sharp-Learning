
// Basic math operations
using System;
class Program {
  static void Main(string[] args)
  {
    Console.WriteLine(20); // whole number and decimal numbers
    Console.WriteLine( 5+8); // + - / * (basic math)
    Console.WriteLine( 5 % 2); // modulator gives back remainder after division
    Console.WriteLine((4+2)*3); //follows PEMDAS
    Console.WriteLine( 5.0 + 8.1); // gives a decimal back
    Console.WriteLine( 5 + 8.2); // gives a decimal
    Console.WriteLine(5 / 2); // will always get an integer back
    Console.WriteLine(5/2.0); // Will always get a decimal back
    int num = 6;
    Console.WriteLine("\n" + num); // prints number
    num++;
    Console.WriteLine(num); // adds 1 to the num
    num--;
    num--;
    Console.WriteLine(num + "\n"); // minues 1 to the num 

    Console.ReadLine();

  }
}

// Method math operations
    //calling a method (Math.)

using System;
class Program {
  static void Main(string[] args)
  {
    Console.WriteLine(Math.Abs(-40)); // Absolute value
    Console.WriteLine(Math.Pow(3,2)); // 3 raised to the 2nd power
    Console.WriteLine(Math.Sqrt(36)); // Square root
    Console.WriteLine("");
    Console.WriteLine(Math.Max(4,90)); // prints largest num
    Console.WriteLine(Math.Min(4,80)); // prints minimum number
    Console.WriteLine("");
    Console.WriteLine(Math.Round(4.2)); // rounds up/down
    Console.WriteLine(Math.Round(4.7));

    Console.ReadLine();

  }
}


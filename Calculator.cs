using System;
class Program {
  static void Main(string[] args)
  {
    int num = Convert.ToInt32("45"); //convert the numerical string into a number
    Console.WriteLine(num + 6);
    Console.WriteLine("");
    Console.Write("Enter a number: ");
    double num1 = Convert.ToDouble(Console.ReadLine()); // to int only allows whole numbers to allows decimals, change it to double
    Console.Write("Enter another number: ");
    double num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(num1 + num2);

    Console.ReadLine(); // allows us to see the output of our programs
    // waits for the user to enter something, so does not just close out program
    //
  }
}
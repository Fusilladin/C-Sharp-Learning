using System;
class Program {
  static void Main(string[] args)
  {
    Console.WriteLine("Hello");
    Console.Write("Enter your name: "); // Will not go to a new line
    string name = Console.ReadLine(); //string stores a variable
    Console.Write("Enter your age: ");
    string age = Console.ReadLine();    
    Console.WriteLine("Hello " + name + "\nYour age is " + age );

    Console.ReadLine(); // allows us to see the output of our programs
    // waits for the user to enter something, so does not just close out program
    //
  }
}
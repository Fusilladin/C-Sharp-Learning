using System;
class DataTypes {
  static void Main(string[] args)
  {
    string phrase = "John Academy";
    Console.WriteLine(phrase + " is cool");
    Console.WriteLine();
    Console.WriteLine(phrase.Length); // shows the Length
    Console.WriteLine(phrase.ToUpper()); // ToLower
    Console.WriteLine(phrase.Contains("Academy"));
    Console.WriteLine( phrase[0]);
    Console.WriteLine();
    Console.WriteLine(phrase.IndexOf("Academy")); // shows where the phrase index starts
    Console.WriteLine(phrase.IndexOf("z")); // -1 means that it does not exist
    Console.WriteLine(phrase.Substring(8, 3)); // first number is index to start and second is how many char to write
    
    Console.ReadLine();

  }
}
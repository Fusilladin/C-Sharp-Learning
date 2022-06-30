using System;
class Program 
{
  static void Main(string[] args)
  {
    Console.WriteLine();
    
    SayHi("Mike", 33);
    SayHi("John", 56);
    SayHi("Tom", 87);
    
    Console.ReadLine();
  }
  
  static void SayHi(string name, int age)
  {
      Console.WriteLine("Hello " + name + " you are " + age);
  }
}
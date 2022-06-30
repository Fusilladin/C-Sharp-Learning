using System;
class Program {
  static void Main(string[] args)
  {
    bool isMale = false;
    bool isTall = false;
    
    if(isMale && isTall) // &&(And) ||(or)
    {
        Console.WriteLine("You are a tall male.");
    } else if (isMale && !isTall){
        Console.WriteLine("You are a short male.");
    } else if(!isMale && isTall){
        Console.WriteLine("You are a tall female.");
    } else
    {
        Console.WriteLine("You are not male and not tall.");
    }
    Console.ReadLine();

  }
}

/////////////////

using System;
class Program {
  static void Main(string[] args)
  {
    Console.WriteLine(GetMax(20,10));  
      
    Console.ReadLine();

  }
  static int GetMax(int num1, int num2)
  {
    int result;
    if(num1 > num2){
        result = num1;
    }else{
        result = num2;
    }
    
    
    return result; 
  }
}

/////////////////


using System;
class Program {
  static void Main(string[] args)
  {
    Console.WriteLine(GetMax(40,42,4));  
      
    Console.ReadLine();

  }
  static int GetMax(int num1, int num2, int num3) // != not equal
  {
    int result;
    if(num1>=num2 && num1 >= num3) // == does equal (comparison)
    {
        result = num1;
    } 
    else if(num2 >= num1 && num2 >= num3)
    {
        result = num2;
    }
    else
    {
        result = num3;
    }
 
    return result; 
  }
}





















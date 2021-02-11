using System;

class MainClass {
  public static void Main (string[] args) {

    int Farenheit;
    int Celsius;
    Console.WriteLine ("Enter Celsius");
    
    Celsius = int.Parse(Console.ReadLine());

    Farenheit = (Celsius*9/5)+32;

    Console.WriteLine(("Farenheit equivalent to ") + Celsius + (" celsius is ") + Farenheit );

    if ( Farenheit < 32)
    {Console.WriteLine("It is below freezing");
    }

     else if (Farenheit > 212)
    {Console.WriteLine("It is at boilng temperature");
    }

  }
}
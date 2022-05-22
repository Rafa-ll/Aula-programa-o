using System;
class Program{
  public static void Main() {

    double h = double.Parse(Console.ReadLine());
    double kmh = double.Parse(Console.ReadLine());
    double l = (h*kmh)/12.0;
    Console.WriteLine(Math.Round(litros,3));
    
  }
}
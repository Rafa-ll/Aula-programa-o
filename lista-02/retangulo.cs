using System;
class Program{
  public static void Main(){

    Console.WriteLine("Digite a base e a altura do retângulo:");
    double b = Double.Parse(Console.ReadLine());
    double a = Double.Parse(Console.ReadLine());
    double area = b*a;
    double p = b*2 + a*2;
    Console.WriteLine($"Teste {b}, {a}, {area}, {p}");
  }
}

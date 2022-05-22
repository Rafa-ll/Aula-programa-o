using System;
class Program{
  public static void Main(){

    Console.WriteLine("Digite a base e a altura do retângulo:");
    double b = Double.Parse(Console.ReadLine());
    double a = Double.Parse(Console.ReadLine());
    double area = b*a;
    double p = b*2 + a*2;
    double d = Math.Sqrt(a*a + b*b);
    Console.WriteLine($"Área = {area:0.00} - Perímetro = {p:0.00} - Diagonal = {d:0.00}");
  }
}

using System;
class Program{
  public static void Main(){

    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
    int n2 = int.Parse(Console.ReadLine());
    int p1 = int.Parse("2");
    int p2 = int.Parse("3");
    int media = (n1 * p1 + n2 * p2)/(p1 + p2);
    Console.WriteLine($"Média parcial: {media}");    
   
  }
}
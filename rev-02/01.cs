using System;
class Program{
  public static void Main() {

    int e1 = int.Parse(Console.ReadLine());
    int e2 = int.Parse(Console.ReadLine());
    
    if (e1 > e2)
    {
      Console.WriteLine($"Maior = {e1}");
    }
    else if (e1 < e2)
    {
      Console.WriteLine($"Maior = {e2}");
    }
    else
    {
      Console.WriteLine("Números iguais");
    }

  }
}


//    string a = Console.ReadLine();
//    string[] b = a.Split();
//    int e1 = int.Parse(b[0]);
//    int e2 = int.Parse(b[1]);
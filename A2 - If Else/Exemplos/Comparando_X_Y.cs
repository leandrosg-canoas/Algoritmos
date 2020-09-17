using System;

class MainClass {
  public static void Main (string[] args) {

    int x;
    int y;

    Console.Write("Digite o valor de X: ");
    x = int.Parse( Console.ReadLine() );

    Console.Write("Digite o valor de Y: ");
    y = int.Parse( Console.ReadLine() );

    if (x > y) 
    {
      Console.WriteLine("X é maior que Y");
    } 
    else if (x < y) 
    {
      Console.WriteLine("X é menor que Y");
    } 
    else 
    {
      Console.WriteLine("X é igual a Y");
    }
  }
}
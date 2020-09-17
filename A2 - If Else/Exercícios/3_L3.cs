using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Write("Digite um número: ");
    int numero = int.Parse( Console.ReadLine() );

    if(numero % 2 == 0)
    {
      Console.WriteLine("Este número é par");
    }
    else
    {
      Console.WriteLine("Este número é impar");
    }
  }
}
using System;

class MainClass {
  public static void Main (string[] args)
  {
    Console.Write("Digite um valor: ");
    float numero = float.Parse( Console.ReadLine() );

    if (numero > 0)
    {
      Console.WriteLine("O dobro de " + numero + " é " + numero * 2); 
    }
    else
    {
      Console.WriteLine("O triplo de " + numero + " é " + numero * 3); 
    }
  }
}
using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int cavalos;

    Console.Write("Quantidade de Cavalos: ");
    cavalos = int.Parse( Console.ReadLine() );

    int ferraduras = cavalos * 4;

    Console.WriteLine("Ferraduras: " + ferraduras);
  }
}
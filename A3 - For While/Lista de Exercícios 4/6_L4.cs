using System;

class MainClass {
  public static void Main (string[] args) 
  {
    // Elabore um programa que lê um número e mostra sua tabuada do 1 ao 10.

    Console.Write("Digite um número para a tabuada: ");
    int numero = int.Parse( Console.ReadLine() );

    for (int i = 1; i < 11; i++)
    {
      Console.WriteLine(i + " x " + numero + ": " + i * numero);
    }
  }
}
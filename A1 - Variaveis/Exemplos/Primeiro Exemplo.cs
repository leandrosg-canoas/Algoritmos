using System;

class MainClass {
  public static void Main (string[] args) {   

    int numero;
    Console.Write("Digite um número: ");
    numero = int.Parse( Console.ReadLine() );

    Console.WriteLine("Você digitou " + (numero + 1));
  }
}
using System;

class MainClass {
  public static void Main (string[] args) {

    Console.Write("Escreva seu nome: ");
    string nome = Console.ReadLine();

    for(int i = 0; i < 10; i++)
    {
      Console.WriteLine(nome);
    }
  }
}
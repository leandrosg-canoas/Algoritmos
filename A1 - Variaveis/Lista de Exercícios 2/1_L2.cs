using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int altura;
    int largura;

    Console.Write("Digite a Altura: ");
    altura = int.Parse( Console.ReadLine() );

    Console.Write("Digite a Largura: ");
    largura = int.Parse( Console.ReadLine() );

    int area = largura * altura;

    Console.WriteLine("Área do terreno: " + area);
  }
}
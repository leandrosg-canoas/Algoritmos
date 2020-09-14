using System;

class MainClass {
  public static void Main (string[] args) 
  {
    double preco_litro;
    double valor;

    Console.Write("Valor a abastacer? R$ ");
    valor = double.Parse( Console.ReadLine() );

    Console.Write("Preço da gasolina: R$ ");
    preco_litro = double.Parse( Console.ReadLine() );

    double litros = valor / preco_litro;

    Console.Write("Total: " + litros + " litros");
  }
}
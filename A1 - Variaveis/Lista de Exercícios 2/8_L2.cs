using System;

class MainClass {
  public static void Main (string[] args) 
  {
    float valor_compra;

    Console.Write("Valor da compra: R$ ");
    valor_compra = float.Parse(Console.ReadLine());

    float desconto = valor_compra * 0.85f;

    Console.WriteLine("Preço com desconto: R$ " + desconto);
  }
}
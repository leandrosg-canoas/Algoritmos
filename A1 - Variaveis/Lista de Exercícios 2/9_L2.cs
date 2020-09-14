using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int quantidade_camisetas;
    int quantidade_calcas;
    int quantidade_cintos;

    Console.Write("Camisetas compradas: ");
    quantidade_camisetas = int.Parse( Console.ReadLine() );

    Console.Write("Calças compradas: ");
    quantidade_calcas = int.Parse( Console.ReadLine() );

    Console.Write("Cintos compradas: ");
    quantidade_cintos = int.Parse( Console.ReadLine() );

    float total = quantidade_camisetas * 19 + quantidade_calcas * 75 + quantidade_cintos * 40;
    float desconto = total * 0.9f;

    Console.WriteLine("Total da Venda: R$ " + desconto);
  }
}
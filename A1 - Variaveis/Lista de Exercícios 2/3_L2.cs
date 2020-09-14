using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int paes;
    int broas;

    Console.Write("Pães comprados: ");
    paes = int.Parse( Console.ReadLine() );

    Console.Write("Broas compradas: ");
    broas = int.Parse( Console.ReadLine() );

    double venda_paes = paes * 0.25;
    double venda_broas = broas * 1.50;

    Console.Write("R$" + venda_paes + " de Pães vendidos");
    Console.Write("R$" + venda_broas + " de Broas vendidas");
  }
}
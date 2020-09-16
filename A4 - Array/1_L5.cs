using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int [] valores = new int[5];

    for(int i = 0; i < 5; i++)
    {
      Console.Write("Digite o valor da posição " + i + ": ");
      valores[i] = int.Parse( Console.ReadLine());
    }

    for(int i = 0; i < 5; i++)
    {
      Console.WriteLine("Valor na posição " + i + ": " + valores[i]);
    }
  }
}
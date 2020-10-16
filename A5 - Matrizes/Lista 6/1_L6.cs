using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int [,] matriz = new int [,] 
    {
      {0, 2},
      {3, 4}
    };

    int soma = 0;

    for(int i = 0; i < 2; i++)
    {
      for(int j = 0; j < 2; j++)
      {
        soma += matriz[i, j];
      }
    }

    Console.WriteLine ("Soma: " + soma);
  }
}
using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int [,] matriz = new int [,] 
    {
      {0, 2, 1},
      {4, 1, 6},
      {1, 8, 9}
    };

    int soma = 0;
    int tamanho = 3;

    for(int i = 0; i < tamanho; i++)
    {
      for(int j = 0; j < tamanho; j++)
      {
        if(i + j == tamanho - 1)
        {
          Console.WriteLine(i + " " + j);
          soma += matriz[i, j];
        }
      }
    }

    Console.WriteLine ("Soma: " + soma);
  }
}
using System;

class MainClass {
  public static void Main (string[] args)
  {
    int [,] matriz = new int [,] 
    {
      {1, 2},
      {3, 4}
    };

    for(int linha = 0; linha < 2; linha++)
    {
      for(int coluna = 0; coluna < 2; coluna++)
      {
        Console.Write(matriz[linha, coluna] + " ");
      }

      Console.WriteLine("");
    }
  }
}
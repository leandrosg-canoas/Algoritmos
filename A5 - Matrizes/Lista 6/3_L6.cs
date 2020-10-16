using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int [,] matriz = new int [,] 
    {
      {8, 0,  7},
      {1, 2,  0},
      {3, 0, 4}
    };

    int tamanho = 3;

    int somaLinha1 = 0, somaLinha2 = 0, somaLinha3 = 0;
    int somaColuna1 = 0, somaColuna2 = 0, somaColuna3 = 0;

    for(int i = 0; i < tamanho; i++)
    {
      for(int j = 0; j < tamanho; j++)
      {
        if (i == 0)
        { 
          somaLinha1 += matriz[i, j]; 
        }
        
        if (i == 1)
        { 
          somaLinha2 += matriz[i, j]; 
        }

        if (i == 2)
        { 
          somaLinha3 += matriz[i, j]; 
        }

        if (j == 0)
        { 
          somaColuna1 += matriz[i, j];
        }

        if (j == 1)
        { 
          somaColuna2 += matriz[i, j]; 
        }

        if (j == 2)
        { 
          somaColuna3 += matriz[i, j]; 
        }
      }
    }

    int somaDasLinhas = somaLinha1 + somaLinha2 + somaLinha3;
    int somaDasColunas = somaColuna1 + somaColuna2 + somaColuna3;

    Console.WriteLine("Soma da linha 1: " + somaLinha1);
    Console.WriteLine("Soma da linha 2: " + somaLinha2);
    Console.WriteLine("Soma da linha 3: " + somaLinha3);
    Console.WriteLine("Soma da coluna 1: " + somaColuna1);
    Console.WriteLine("Soma da coluna 2: " + somaColuna2);
    Console.WriteLine("Soma da coluna 3: " + somaColuna3);
  }
}
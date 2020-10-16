using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int [,] matriz = new int [,] 
    {
      {0, 0,  0},
      {1, 2,  0},
      {0, 0,  0}
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

    if(somaLinha1 == 0)
    {
      Console.WriteLine("A linha 1 é nula");
    }

    if(somaLinha2 == 0)
    {
      Console.WriteLine("A linha 2 é nula");
    }

    if(somaLinha3 == 0)
    {
      Console.WriteLine("A linha 3 é nula");
    }

    if(somaColuna1 == 0)
    {
      Console.WriteLine("A Coluna 1 é nula");
    }

    if(somaColuna2 == 0)
    {
      Console.WriteLine("A Coluna 2 é nula");
    }

    if(somaColuna3 == 0)
    {
      Console.WriteLine("A Coluna 3 é nula");
    }
  }
}
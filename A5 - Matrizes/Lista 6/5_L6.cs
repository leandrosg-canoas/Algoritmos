using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int [,] matriz = new int [,] 
    {
      {8, 0,  7},
      {4, 5,  6},
      {3, 10, 2}
    };

    int tamanho = 3;

    int somaLinha1 = 0, somaLinha2 = 0, somaLinha3 = 0;
    int somaColuna1 = 0, somaColuna2 = 0, somaColuna3 = 0;
    int somaDiagonalPrincipal = 0, somaDiagonalSecundaria = 0;

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

        if (i == j)
        { 
          somaDiagonalPrincipal += matriz[i, j];
        }

        if (i + j == tamanho - 1)
        { 
          somaDiagonalSecundaria += matriz[i, j];
        }
        
      }
    }

    Console.Clear();

    int somaDasLinhas = somaLinha1 + somaLinha2 + somaLinha3 + somaDiagonalPrincipal;
    int somaDasColunas = somaColuna1 + somaColuna2 + somaColuna3 + somaDiagonalSecundaria;

    if (somaDasLinhas == somaDasColunas)
    {
      Console.WriteLine("Esta Matriz é um Quadrado Mágico");
    }
    else
    {
      Console.WriteLine("Esta Matriz não é um Quadrado Mágico");
    }
  }
}
using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Write("Digite o tamanho do array: ");
    int size = int.Parse( Console.ReadLine() );

    int [] valores = new int [size];

    for(int i = 0; i < size; i++)
    {
      Console.Write("Digite um valor na posição " + i + ": ");
      valores[i] = int.Parse( Console.ReadLine() );
    }

    for(int i = 0; i < size; i++)
    {
      for (int j = 0; j < size - 1; j++)
      {
        if (valores[j] > valores[j + 1])
        {
          int copia = valores[j];
          valores[j] = valores[j + 1];
          valores[j + 1] = copia;
        }
      }
    }

    for(int i = 0; i < size; i++)
    {
      Console.WriteLine(valores[i]);
    }
  }
}
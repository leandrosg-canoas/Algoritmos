using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int negativos = 0;
    int size;

    Console.Write("Digite o tamanho do array: ");
    size = int.Parse( Console.ReadLine() );

    int [] valores = new int [size];

    for(int i = 0; i < size; i++)
    {
      Console.Write("Digite um valor na posição " + i + ": ");
      valores[i] = int.Parse( Console.ReadLine() );

      if (valores[i] < 0) {
        negativos++; // Poderia ser negativos += 1 também
      }
    }

    Console.WriteLine ("Quantidade de valores negativos: " + negativos);
  }
}
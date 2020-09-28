using System;

class MainClass {
  public static void Main (string[] args) 
  {
    // Preenchendo um array manualmente
    int [] numeros = new int [] {1, 3, 5, 4, 3};

    // Preenchendo um array pelo teclado
    Console.Write("Digite um tamanho: ");
    int size = int.Parse(Console.ReadLine());

    int [] array = new int [size];

    // Usamos o for para percorrer o array e acessar todos os seus valores
    for (int i = 0; i < size; i++)
    {
      Console.Write("Digite um valor na posição " + i + ": ");
      array[i] = int.Parse(Console.ReadLine());
    }

    for(int i = 0; i < size; i++)
    {
      Console.WriteLine(array[i]);
    }
  }
}
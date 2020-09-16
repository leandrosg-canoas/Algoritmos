using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int menor;
    int size; 

    Console.Write("Digite o tamanho do array: ");
    size = int.Parse( Console.ReadLine() );

    int [] valores = new int [size];

    for(int i = 0; i < size; i++)
    {
      Console.Write("Digite um valor na posição " + i + ": ");
      valores[i] = int.Parse( Console.ReadLine() );
    }

    menor = valores[0];

    for(int i = 0; i < size; i++)
    {
      if (valores[i] < menor) {
        menor = valores[i];
      }
    }

    Console.WriteLine ("Menor valor: " + menor);
  }
}
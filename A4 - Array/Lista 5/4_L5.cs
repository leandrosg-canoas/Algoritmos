using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int maior;
    int size; 

    Console.Write("Digite o tamanho do array: ");
    size = int.Parse( Console.ReadLine() );

    int [] valores = new int [size];

    for(int i = 0; i < size; i++)
    {
      Console.Write("Digite um valor na posição " + i + ": ");
      valores[i] = int.Parse( Console.ReadLine() );
    }

    maior = valores[0];

    for(int i = 0; i < size; i++)
    {
      if (valores[i] > maior) {
        maior = valores[i]; 
      }
    }

    Console.WriteLine ("Maior valor: " + maior);
  }
}
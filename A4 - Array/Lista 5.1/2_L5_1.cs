using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int [] array = new int [] {1, 2, 3, 4, 5};

    int soma = 0;

    for(int i = 0; i < 5; i++)
    {
      soma += array[i];
    }

    Console.WriteLine("Soma total do array: " + soma);
  }
}
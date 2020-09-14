using System;

class MainClass {
  public static void Main (string[] args)
  {
    // Faça um programa que imprime os dez primeiros pares positivos.

    for (int i = 2; i < 21; i++)
    {
      if (i % 2 == 0)
        Console.WriteLine (i);
    }
  }
}
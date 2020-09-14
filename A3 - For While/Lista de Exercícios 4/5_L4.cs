using System;

class MainClass {
  public static void Main (string[] args) 
  {
    // Faça um programa que imprime os dez primeiros números múltiplos de 4.

    for (int i = 4; i < 41; i++)
    {
      if (i % 4 == 0)
      {
        Console.WriteLine(i);
      }
    }
  }
}
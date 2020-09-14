using System;

class MainClass {
  public static void Main (string[] args) 
  {
    // O Continue apenas pula o laço atual e todo o código que vem depois dele, que está dentro do for

    for (int i = 0; i < 5; i++)
    {
      if (i == 0)
      {
        continue;
      }

      Console.WriteLine(i);
    }
  }
}
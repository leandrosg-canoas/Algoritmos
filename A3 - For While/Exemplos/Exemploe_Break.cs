using System;

class MainClass {
  public static void Main (string[] args) 
  {
    // O Break encerra o for completamente, não executando o Console.WriteLine

    for (int i = 0; i < 5; i++)
    {
      if (i == 0)
      {
        break;
      }

      Console.WriteLine(i);
    }
  }
}
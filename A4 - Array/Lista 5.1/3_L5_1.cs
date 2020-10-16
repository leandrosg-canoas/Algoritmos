using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int [] original = new int [] {1, 2, 0, 3, 5};
    int [] copia = new int [5];

    for(int i = 0; i < 5; i++)
    {
      copia[i] = original[i];
    }

    for(int i = 0; i < 5; i++)
    {
      Console.WriteLine(copia[i]);
    }
  }
}
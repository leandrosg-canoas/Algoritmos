using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int [] array = new int [] { 1, 2, 0, 5, 4};

    for(int i = 4; i >= 0; i--)
    {
      Console.WriteLine(array[i]);
    }
  }
}
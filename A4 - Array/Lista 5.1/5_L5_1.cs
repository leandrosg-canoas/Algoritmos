using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int [] array = new int [5];

    int anterior = 0;

    for (int i = 0; i < 5; i++) 
    {
	    array[i] = i + anterior;
      anterior = i;

      Console.WriteLine (array[i]);
	  }
  }
}
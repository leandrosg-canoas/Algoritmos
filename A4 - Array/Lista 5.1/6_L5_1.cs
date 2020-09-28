using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int [] array = new int [] {0, 2, 3, 4, 5};
    int [] copy = new int [5];

    for(int i = 0; i < 5; i++)
    {
      copy[i] = array[i];
    }

    for (int i = 0; i < 5; i++) 
    {
	    array[i] = copy[4 - i];
	  }

    for(int i = 0; i < 5; i++)
    {
      Console.WriteLine(array[i]);
    }
  }
}
using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string [] palavras = new string [] {"Allan", "Alex", "Alberto"};

    string menor;
    int size = 3;

    menor = palavras[0];

    for(int i = 0; i < size; i++)
    {
      if (string.Compare(palavras[i], menor) < 0) 
      {
        menor = palavras[i];
      }
    }

    Console.Clear();
    Console.WriteLine ("Menor palavra: " + menor);
  }
}
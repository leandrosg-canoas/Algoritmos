using System;

class MainClass {
  public static void Main (string[] args) 
  {
    // Depois de rodar o código pela primeira vez, experimente apagar a linha 11 e rodar novamente
    
    bool condition = true;
    
    while (condition)
    {
      Console.WriteLine ("Travou");
      condition = false;
    }
  }
}
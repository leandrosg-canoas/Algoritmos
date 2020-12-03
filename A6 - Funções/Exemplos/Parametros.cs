using System;

class MainClass 
{
  static void WriteMessage(string message)
  {
    Console.WriteLine(message);
  }

  static int Soma(int a, int b)
  {
    return a + b;
  }

  public static void Main (string[] args) 
  {
    int resultado = Soma(1, 1);

    WriteMessage("Soma: " + Soma(1, 1) );

    int valor = int.Parse( Console.ReadLine() );
  }
}
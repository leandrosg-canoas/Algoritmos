using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Write("Digite o valor de A: ");
    int A = int.Parse( Console.ReadLine() );

    Console.Write("Digite o valor de B: ");
    int B = int.Parse( Console.ReadLine() );

    Console.Write("Digite o valor de C: ");
    int C = int.Parse( Console.ReadLine() );

    int A_B = A + B;
    int A_C = A + C;

    if (A_B < A_C)
    {
      Console.WriteLine("A + B é menor que A + C");
    }

    // else neste caso é opcional
  }
}
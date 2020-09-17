using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Write("Digite o valor de A: ");
    int A = int.Parse( Console.ReadLine() );

    Console.Write("Digite o valor de B: ");
    int B = int.Parse( Console.ReadLine() );

    int C;

    if(A == B)
    {
      C = A + B;
    }
    else
    {
      C = A * B;
    }

    Console.WriteLine("Resultado de C: " + C);
  }
}
using System;

class MainClass {
  public static void Main (string[] args) {

    Console.Write ("Digite o numerador: ");
    double numerador = double.Parse( Console.ReadLine() );

    Console.Write ("Digite o denominador: ");
    double denominador = double.Parse( Console.ReadLine() );

    if (denominador != 0)
    {
      double resultado = numerador / denominador;

      Console.WriteLine ("Resultado: " + resultado);
    }
    else
    {
      Console.WriteLine ("Não pode dividir por zero");
    }
  }
}
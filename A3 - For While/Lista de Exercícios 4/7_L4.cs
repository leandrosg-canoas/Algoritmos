using System;

class MainClass {
  public static void Main (string[] args) 
  {
    // Faça um programa que leia um número digitado pelo usuário. Repita a operação de multiplicar ele por três (imprimindo o novo valor) enquanto ele for menor do que 150.
    
    Console.Write ("Digite um valor: ");
    int numero = int.Parse( Console.ReadLine() );

    while(numero < 150)
    {
      Console.WriteLine(numero);
      numero *= 3;
    }
  }
}
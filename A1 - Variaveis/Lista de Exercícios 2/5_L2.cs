using System;

class MainClass {
  public static void Main (string[] args) 
  {
    float grauA;
    float grauB;

    Console.Write("Nota grau A: ");
    grauA = float.Parse( Console.ReadLine() );

    Console.Write("Nota grau B: ");
    grauB = float.Parse( Console.ReadLine() );

    float media_final = (grauA + grauB * 2) / 2;

    Console.WriteLine("Média final: " + media_final);
  }
}
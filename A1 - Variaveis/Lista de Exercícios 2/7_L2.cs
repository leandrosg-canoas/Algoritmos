using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int minutos;

    Console.Write("Tempo em minutos: ");
    minutos = int.Parse( Console.ReadLine() );

    int segundos = minutos * 60;

    Console.WriteLine("Tempo em segundos: " + segundos);
  }
}
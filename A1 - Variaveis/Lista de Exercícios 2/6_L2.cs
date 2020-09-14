using System;

class MainClass {
  public static void Main (string[] args) 
  {
    float centimetros;

    Console.Write("Digite sua altura em centimetros: ");
    centimetros = float.Parse( Console.ReadLine() );

    float metros = centimetros / 100;

    Console.WriteLine ("Altura em metros: " + metros);
  }
}
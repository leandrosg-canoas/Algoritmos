using System;

class MainClass {
  public static void Main (string[] args) {

    float porcento;
    
    Console.Write("Digite um valor: ");

    porcento = float.Parse( Console.ReadLine() );
    
    porcento /= 100;

    Console.WriteLine("Porcentagem: " + porcento);
  }
}
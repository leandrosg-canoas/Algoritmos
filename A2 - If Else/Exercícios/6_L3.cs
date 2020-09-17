using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Write("Digite sua altura: ");
    float altura = float.Parse(Console.ReadLine());

    Console.Write("Digite seu sexo: ");
    string sexo = Console.ReadLine();

    float peso_ideal;

    if (string.Compare(sexo, "m") == 0)
    {
      peso_ideal = (72.7f * altura) - 58f;
    }
    else
    {
      peso_ideal = (62.1f * altura) - 44.7f;
    }

    Console.WriteLine("Seu peso ideal é " + peso_ideal + " kg");
  }
}
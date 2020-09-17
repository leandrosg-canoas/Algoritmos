using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Write("Digite seu sexo: ");
    string sexo = Console.ReadLine();

    if (string.Compare(sexo, "m") == 0)
    {
      Console.WriteLine("Masculino");
    }
    else if(string.Compare(sexo, "f") == 0)
    {
      Console.WriteLine("Feminino");
    }

    // Mais informações de como o string.Compare funciona em:
    // https://www.c-sharpcorner.com/UploadFile/mahesh/compare-strings-in-C-Sharp/
  }
}
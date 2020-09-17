using System;

class MainClass {
  public static void Main (string[] args) {

    bool first_condition = true;
    bool second_condition = true;

    if (first_condition)
    {
      Console.WriteLine ("Condição Verdadeira");
    }
    else
    {
      Console.WriteLine ("Condição Falsa");
    }

    if (first_condition && second_condition)
    {
      Console.WriteLine ("Condição Verdadeira");
    }
    else
    {
      Console.WriteLine ("Condição Falsa");
    }
    
    if (first_condition || second_condition)
    {
      Console.WriteLine ("Condição Verdadeira");
    }
    else
    {
      Console.WriteLine ("Condição Falsa");
    }

    if (!first_condition)
    {
      Console.WriteLine ("Condição Verdadeira");
    }
    else
    {
      Console.WriteLine ("Condição Falsa");
    }
  }
}
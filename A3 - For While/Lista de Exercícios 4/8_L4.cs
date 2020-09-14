using System;

class MainClass {
  public static void Main (string[] args) 
  {
    //Escreva um programa que apresente quatro opções: (a) consulta saldo, (b) saque e (c) depósito e (d) sair. O saldo deve iniciar em R$ 0,00. A cada saque ou depósito o valor do saldo deve ser atualizado.

    float saldo = 0f;

    string option = "";

    while (true)
    {
      Console.WriteLine ("Opções");
      Console.WriteLine ("(a) Consulta Saldo");
      Console.WriteLine ("(b) Saque");
      Console.WriteLine ("(c) Depósito");

      Console.Write("Opção desejada: ");
      option = Console.ReadLine();

      switch (option)
      {
        case "a": Console.WriteLine("Seu saldo: " + saldo);
          break;

        case "b":
        {
          Console.Write("Valor do saque: ");

          float saque = float.Parse( Console.ReadLine() );

          if (saldo - saque < 0)
          {
            Console.WriteLine("Saldo Insuficiente");
          }
          else
          {
            saldo -= saque;
            Console.WriteLine("Você sacou R$" + saque);
          }

          break;
        }
        case "c": 
          Console.Write("Digite o valor a ser depositado: ");
          float valor = float.Parse( Console.ReadLine() );
          saldo += valor;
          Console.WriteLine("Você depositou R$" + valor);
          break;

        case "s": break;
          break;

        default: Console.WriteLine("Opção Inválida");
          break;
      }
    }
  }
}
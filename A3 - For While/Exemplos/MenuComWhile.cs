using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;

            while (option != -1)
            {
                // Menu com Switch
                Console.WriteLine("Menu de Switch");
                Console.WriteLine("[1] Escolha A");
                Console.WriteLine("[2] Escolha B");
                Console.WriteLine("[-1] Sair" + "\n");

                // \n - Quebra a linha, coloca um espaço a mais

                Console.Write("Digite uma opção: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Escolheu A \n");
                        break;

                    case 2:
                        Console.WriteLine("Escolheu B \n");
                        break;

                    case -1:
                        Console.WriteLine("Até mais \n");
                        break;

                    default:
                        Console.WriteLine("Opção Inválida \n");
                        break;
                }
            }
        }
    }
};

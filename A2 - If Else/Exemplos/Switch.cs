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
            // Menu com Switch
            Console.WriteLine("Menu de Switch");
            Console.WriteLine("[1] Escolha A");
            Console.WriteLine("[2] Escolha B" + "\n");

            // \n - Quebra a linha, coloca um espaço a mais

            Console.WriteLine("Digite uma opção: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Escolheu A");
                    break;

                case 2:
                    Console.WriteLine("Escolheu B");
                    break;

                default: Console.WriteLine("Opção Inválida");
                    break;
            }
        }
    }
};

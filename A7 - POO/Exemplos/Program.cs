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
            Dog viraLata = new Dog();
            Dog maltez = new Dog();

            viraLata.SetName("Jhonny");
            maltez.SetName("Shane");

            Console.WriteLine(viraLata.GetName());
            Console.WriteLine(maltez.GetName());
        }
    }
};

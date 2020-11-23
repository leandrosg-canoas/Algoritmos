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
            Dog [] dog = new Dog[3];

            for (int i = 0; i < 3; i++)
            {
                dog[i] = new Dog();
            }

            dog[0].SetName("Jhonny");
            dog[1].SetName("Shelby");
            dog[2].SetName("Doug");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(dog[i].GetName());
            }
        }
    }
};

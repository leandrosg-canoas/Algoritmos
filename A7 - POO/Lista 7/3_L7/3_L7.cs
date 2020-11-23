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
            Dog dog = new Dog();

            dog.toy = new Toy();

            dog.toy.SetName("Dog Toy");

            Console.WriteLine(dog.toy.GetName());
        }
    }
};

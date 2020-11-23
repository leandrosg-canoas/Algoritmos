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

            // Instância é criada aqui e passada como parâmetro 
            Toy toy = new Toy();

            dog.SetToy(toy);

            dog.GetToy().SetName("Dog Toy");

            Console.WriteLine(dog.GetToy().GetName());
        }
    }
};

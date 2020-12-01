using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Day
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday,
}

namespace A7_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = int.Parse(Console.ReadLine());

            Day currentDay = Day.Sunday

            Console.Write("Today is " + Convert.ToString(currentDay));

            // Demais informações sobre como usar Enums
            // 
        }
    }
};

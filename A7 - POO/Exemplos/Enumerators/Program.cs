using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Um enum pode ser criado tanto fora quanto dentro de uma classe
// Isso só muda a acessibilidade deste enum para outras classes
// Passe o mouse sobre algum dos dias criados e veja o valor anexado a eles
enum Day
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

namespace A7_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Day currentDay = Day.Monday;

            Console.WriteLine(currentDay);

            Console.ReadKey();

            // Mais informações aprofundadas
            //https://www.devmedia.com.br/trabalhando-com-enums-em-csharp/26059
        }
    }
};

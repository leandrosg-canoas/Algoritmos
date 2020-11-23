using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7_Exemplo
{
    public class Dog
    {
        string Name;

        Toy toy;

        public void SetName(string _name)
        {
            Name = _name;
        }

        public void SetToy(Toy newToy)
        {
            toy = newToy;
        }

        public string GetName()
        {
            return Name;
        }

        public Toy GetToy()
        {
            return toy;
        }
    }
}

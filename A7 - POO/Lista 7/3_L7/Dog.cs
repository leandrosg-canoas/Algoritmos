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

        public Toy toy;

        public void SetName(string _name)
        {
            Name = _name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}

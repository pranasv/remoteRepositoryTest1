using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practice
{
    class Gyvunas
    {
        private int Age;
        protected int Legs;
        public string Name;

        public Gyvunas(string name, int age, int legs)
        {
            Name = name;
            Age = age;
            Legs = legs;
        }

    }
}

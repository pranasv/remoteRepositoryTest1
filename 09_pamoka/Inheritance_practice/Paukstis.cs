using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practice
{
    class Paukstis:Gyvunas
    {
        private int Wings;
        protected string Type;
        public int PlunksnuKiekis;
        public Paukstis(string name, int age, int legs, int wings, string type, int plunksnos):base(name, age, legs)
        {
            Wings = wings;
            Type = type;
            PlunksnuKiekis = plunksnos;
        }
    }
}

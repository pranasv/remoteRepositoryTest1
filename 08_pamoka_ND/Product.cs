using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_pamoka_ND
{
    class Product
    {
        private string Name;
        private double Price;
        private double Weight;
        private int x, y, z;
        public Product (string name)
        {
            Name = name;
            Price = 0;
            Weight = 0;
            x = 0;
            y = 0;
            z = 0;
        }
        public void SetPrice (double price)
        {
            Price = price;
        }
        public void SetWeight (double weight)
        {
            Weight = weight;
        }
        public void SetDimm (int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void PrintAllInfo()
        {
            Console.WriteLine("\nPavadinimas: "+Name);
            Console.WriteLine("Kaina: "+Price+" Eur");
            Console.WriteLine("Mase: "+Weight+" kg.");
            Console.WriteLine("Matmenys (A+P+G): "+y+" "+x+" "+z);
        }

    }
}

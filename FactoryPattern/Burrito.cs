using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Burrito : IOrderable
    {
        public int Price { get; set; } = 10;
        public bool ToGo { get; set; }

        public void GetDescription()
        {
            Console.WriteLine($"\nOur burrito comes filled with carne asada, guacamole, rice and beans \nPrice: ${Price}");
        }
    }
}

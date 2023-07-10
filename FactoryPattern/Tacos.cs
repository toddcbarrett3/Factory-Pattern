using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Tacos : IOrderable
    {
        public int Price { get; set; } = 8;
        public bool ToGo { get; set; }

        public void GetDescription()
        {
            Console.WriteLine($"\nComes with 3 tacos with your choice of meat \nPrice: ${Price}");
        }
    }
}

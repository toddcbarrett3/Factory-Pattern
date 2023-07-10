using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Enchiladas : IOrderable
    {
        public int Price { get; set; } = 12;
        public bool ToGo { get; set; }

        public void GetDescription()
        {
            Console.WriteLine($"\nComes with 2 chicken enchiladas covered in our classic green sauce \nPrice: ${Price}");
        }
    }
}

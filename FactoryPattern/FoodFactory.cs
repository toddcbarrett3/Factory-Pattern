using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class FoodFactory
    {
        public static IOrderable OrderFood(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new Tacos();
                case 2:
                    return new Enchiladas();
                case 3:
                    return new Burrito();
                default:
                    return new Tacos();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Constructor
{
    public class BaseCar : ICar
    {
        public string getDescription()
        {
            return "Car includes Extras :";
        }

        public double getPrice()
        {
            return 0;
        }
    }
}
